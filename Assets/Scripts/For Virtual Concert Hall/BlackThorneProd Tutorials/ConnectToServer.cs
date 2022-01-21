using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public TMP_InputField ingameNameInput;
    public TextMeshProUGUI buttonText;
    // Start is called before the first frame update
    public void OnClickConnect()
    {
        if(ingameNameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = ingameNameInput.text;
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.AutomaticallySyncScene = true;
            buttonText.text = "Connecting...";
            Debug.Log("Connecting...");
        }
        
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Test Lobby");
        Debug.Log("Connected");
    } 
}
