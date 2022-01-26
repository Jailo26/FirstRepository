using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;


public class ConnectToServer : MonoBehaviourPunCallbacks
{
    //[SerializeField]
   // private FirebaseManager connector;

    public TMP_InputField ingameNameInput;
    public TextMeshProUGUI buttonText;
    // Start is called before the first frame update

    public void Awake()
    {
        //connector.gameObject.GetComponent<FirebaseManager>();
    }

    public void OnClickConnect()
    {
            buttonText.text = "Connecting...";
            Debug.Log("Connecting...");
            PhotonNetwork.NickName = ingameNameInput.text;
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.AutomaticallySyncScene = true;
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Test Lobby");
        Debug.Log("Connected");
    } 
}
