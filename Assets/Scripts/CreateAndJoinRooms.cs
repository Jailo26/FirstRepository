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
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
