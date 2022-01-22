using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public CameraManager cameraManager;

    public GameObject playerPrefab;

    public bool isSpawned;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float posY;

    private void Awake()
    {
        Vector3 ramdomPosition = new Vector3(Random.Range(minX,maxX),posY, Random.Range(minZ, maxZ));
        GameObject _localPlayer = PhotonNetwork.Instantiate(playerPrefab.name, ramdomPosition, Quaternion.identity);
        isSpawned = true;

        if(isSpawned == true)
        {
            cameraManager.OpenCamera();
        }
        
        //_localPlayer.GetComponent<PlayerSetup>().IsLocalPlayer();     
    }
}
