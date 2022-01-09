using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;

    [Space]
    //public Transform spawnPoint;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    public void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(minX,maxX), Random.Range(minY,maxY));
        PhotonNetwork.Instantiate(player.name,randomPos,Quaternion.identity);
    }

    /*public void SpawnPlayer()
    {
        GameObject _localPlayer = PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity, 0);
        
        _localPlayer.GetComponent<PlayerSetup>().IsLocalPlayer();
    }*/
}
