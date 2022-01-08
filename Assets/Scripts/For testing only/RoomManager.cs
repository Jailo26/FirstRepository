using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    //public string roomName = "Room";
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Conecting...");
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        //PhotonNetwork.JoinLobby();

        Debug.Log("Conected to server");
    }

    /*public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        PhotonNetwork.JoinOrCreateRoom(roomName, null, null);

        Debug.Log("Successfully connected and joined lobby");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        GetComponent<PlayerSpawner>().SpawnPlayer();

        Debug.Log("Successfully connected and joined room");
    }*/
}
