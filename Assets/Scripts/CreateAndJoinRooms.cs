using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public string roomName = "Room";

    private void Start()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();      

        Debug.Log("Successfully connected and joined lobby");
    }

    public void OnClickCreate()
    {
        PhotonNetwork.JoinOrCreateRoom(roomName, null, null);
        Debug.Log("Joining room...");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        PhotonNetwork.LoadLevel("Game");

        Debug.Log("Successfully connected and joined room");
    }

    public void OnClickLeaveRoom()
    {
        PhotonNetwork.LeaveRoom();

        Debug.Log("Leaving...");
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();

        PhotonNetwork.LoadLevel("Test Lobby");

        Debug.Log("Successfully left the room");
    }
}
