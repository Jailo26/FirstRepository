using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public void OnClickConnect()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.AutomaticallySyncScene = true;
        Debug.Log("Connecting...");
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Test Lobby");
        Debug.Log("Connected");
    } 
}
