using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    
    public void JoinRoom()
    {
        //PhotonNetwork.JoinRoom("Game");
        PhotonNetwork.LoadLevel("Game");
        OnJoinedRoom();
    }

    public override void OnJoinedRoom()
    {
        //PhotonNetwork.LoadLevel("Game");
        Debug.Log("PUN Basics Tutorial/Launcher: OnJoinedRoom() called by PUN. Now this client is in a room.");
    }
}
