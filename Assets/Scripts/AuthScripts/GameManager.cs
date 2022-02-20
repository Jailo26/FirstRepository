using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
       
        Input.backButtonLeavesApp = true;
        
    }
    public void ChangeScene(int _sceneIndex)
    {
        SceneManager.LoadSceneAsync(_sceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
        //System.Diagnostics.Process.GetCurrentProcess().Kill();
        Debug.Log("Quitting");
    }
    public void LogoutGame()
    {
        SceneManager.LoadScene("Login");
    }
}
