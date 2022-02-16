using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using TMPro;
using Photon.Pun;

public class FirebaseManager : MonoBehaviour
{
    public static FirebaseManager instance;

    [Header("Firebase")]
    public FirebaseAuth auth;
    public FirebaseUser user;
    [Space(5f)]

    [Header("Login References")]
    [SerializeField]
    private TMP_InputField loginEmail;
    [SerializeField]
    private TMP_InputField loginPassword;
    [SerializeField]
    private TMP_Text loginOutputText;
    [Space(5f)]

    [Header("Register References")]
    [SerializeField]
    private TMP_InputField registerUsername;
    [SerializeField]
    private TMP_InputField registerEmail;
    [SerializeField]
    private TMP_InputField registerPassword;
    [SerializeField]
    private TMP_InputField registerConfirmPassword;
    [SerializeField]
    private TMP_Text registerOutputText;



    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(instance.gameObject);
            instance = this;
        }

        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(checkDependencyTask =>
        {
            var dependencyStatus = checkDependencyTask.Result;

            if (dependencyStatus == DependencyStatus.Available)
            {
                InitializeFirebase();
            }
            else
            {
                Debug.LogError($"Could not resolve all Firebase dependencies {dependencyStatus}");
            }
        });
    }

    private void InitializeFirebase()
    {
        auth = FirebaseAuth.DefaultInstance;

        auth.StateChanged += AuthStateChanged;
        AuthStateChanged(this, null);
    }

    private void AuthStateChanged(object sender, System.EventArgs eventArgs)
    {
        if( auth.CurrentUser != user)
        {
            bool signedIn = user != auth.CurrentUser && auth.CurrentUser != null;

            if(!signedIn && user != null)
            {
                Debug.Log("Signed Out");
            }

            user = auth.CurrentUser;

            if(signedIn)
            {
                Debug.Log($"Signed in: {user.DisplayName}");
            }
        }
    }

    public void ClearOutputs()
    {
        loginOutputText.text = "";
        registerOutputText.text = "";
    }

    public void LoginButton()
    {
        StartCoroutine(LoginLogic(loginEmail.text, loginPassword.text));
      
    }
    public void RegisterButton()
    {
        StartCoroutine(RegisterLogic(registerUsername.text, registerEmail.text, registerPassword.text, registerConfirmPassword.text));
    }

    private IEnumerator LoginLogic(string _email, string _password)
    {
        Credential credential = EmailAuthProvider.GetCredential(_email, _password);

        var loginTask = auth.SignInAndRetrieveDataWithCredentialAsync(credential);

        yield return new WaitUntil(predicate: () => loginTask.IsCompleted);

        if(loginTask.Exception != null)
        {
            FirebaseException firebaseException = (FirebaseException)loginTask.Exception.GetBaseException();
            AuthError error = (AuthError)firebaseException.ErrorCode;
            string output = "Unknown Error, Please Try Again!";

            switch (error)
            {
                case AuthError.MissingEmail:
                    output = "Please Enter Your Email.";
                    break;
                case AuthError.MissingPassword:
                    output = "Please Enter Your Password.";
                    break;
                case AuthError.InvalidEmail:
                    output = "Email Is Invalid.";
                    break;
                case AuthError.WrongPassword:
                    output = "Password Is Incorrect.";
                    break;
                case AuthError.UserNotFound:
                    output = "Account Does Not Exist.";
                    break;
            }
            loginOutputText.text = output;
        }
        else
        {
            if (user.IsEmailVerified)
            {
                yield return new WaitForSeconds(1f);
                GameManager.instance.ChangeScene(3);
                
            }
            else
            {
                GameManager.instance.ChangeScene(3);
            }
        }
    }

    private IEnumerator RegisterLogic (string _username, string _email, string _password, string _confirmPassword)
    {
        if(_username == "")
        {
            registerOutputText.text = "Please Enter Your Username.";
        }
        else if( _password != _confirmPassword)
        {
            registerOutputText.text = "Passwords Do Not Match.";
        }
        else
        {
            var registerTask = auth.CreateUserWithEmailAndPasswordAsync(_email, _password);

            yield return new WaitUntil(predicate: () => registerTask.IsCompleted);

            if (registerTask.Exception != null)
            {
                FirebaseException firebaseException = (FirebaseException)registerTask.Exception.GetBaseException();
                AuthError error = (AuthError)firebaseException.ErrorCode;
                string output = "Unknown Error, Please Try Again!";

                switch (error)
                {
                    case AuthError.EmailAlreadyInUse:
                        output = "Email Already In Use";
                        break;
                    case AuthError.MissingPassword:
                        output = "Please Enter Your Password.";
                        break;
                    case AuthError.InvalidEmail:
                        output = "Email Is Invalid.";
                        break;
                    case AuthError.WeakPassword:
                        output = "Password Is Weak.";
                        break;
                    case AuthError.MissingEmail:
                        output = "Please Enter Your Email.";
                        break;
                }
                registerOutputText.text = output;
            }
            else
            {
                UserProfile profile = new UserProfile
                {
                    DisplayName = _username,
                };

                var defaultUserTask = user.UpdateUserProfileAsync(profile);

                yield return new WaitUntil(predicate: () => defaultUserTask.IsCompleted);

                if (defaultUserTask.Exception != null)
                {
                    user.DeleteAsync();
                    FirebaseException firebaseException = (FirebaseException)defaultUserTask.Exception.GetBaseException();
                    AuthError error = (AuthError)firebaseException.ErrorCode;
                    string output = "Unknown Error, Please Try Again!";

                    switch (error)
                    {
                        case AuthError.Cancelled:
                            output = "Update User Canceled";
                            break;
                        case AuthError.SessionExpired:
                            output = "Timed Out";
                            break;
                    }
                }
                else
                {
                    registerOutputText.text = "Account Successfully Created";
                    registerUsername.text = "";
                    registerEmail.text = "";
                    registerPassword.text = "";
                    registerConfirmPassword.text = "";
                    Debug.Log($"Firebase User Created Successfully: {user.DisplayName}, ({user.UserId})");
                }
            }
        }
    }
}
