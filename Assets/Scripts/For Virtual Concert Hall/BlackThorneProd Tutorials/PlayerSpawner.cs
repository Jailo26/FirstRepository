using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public CameraManager cameraManager;

    public GameObject playerPrefab;

    GameObject _localPlayer;

    public bool isSpawned;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float posY;

    public void Awake()
    {
        Vector3 ramdomPosition = new Vector3(Random.Range(minX,maxX),posY, Random.Range(minZ, maxZ));
        _localPlayer = PhotonNetwork.Instantiate(playerPrefab.name, ramdomPosition, Quaternion.identity);
        isSpawned = true;

        if(isSpawned == true)
        {
            cameraManager.OpenCamera();
        }
        
        //_localPlayer.GetComponent<PlayerSetup>().IsLocalPlayer();     
    }

    public void DisableMovement()
    {
        _localPlayer.GetComponent<InputManager>().enabled = false;
    }

    public void EnableMovement()
    {
        _localPlayer.GetComponent<InputManager>().enabled = true;
    }
}
