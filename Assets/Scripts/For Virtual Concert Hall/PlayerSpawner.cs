using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    //public Transform spawnPoints;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float posY;

    private void Start()
    {
        Vector3 ramdomPosition = new Vector3(Random.Range(minX,maxX),posY, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, ramdomPosition, Quaternion.identity);
    }
}
