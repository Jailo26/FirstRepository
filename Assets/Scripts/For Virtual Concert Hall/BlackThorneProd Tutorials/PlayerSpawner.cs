using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerSpawner : MonoBehaviour
{
    public CameraManager cameraManager;

    public GameObject playerPrefab;

    GameObject _localPlayer;

    [SerializeField] Slider vcSlider;

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

        _localPlayer.GetComponent<AudioSource>();
    }

    public void DisableMovement()
    {
        //_localPlayer.GetComponent<InputManager>().enabled = false;
        _localPlayer.GetComponent<PlayerLocomotion>().runningSpeed = 0f;
        _localPlayer.GetComponent<InputManager>().moveAmount = 0f;
        _localPlayer.GetComponent<InputManager>().movementInput.x = 0f;
        _localPlayer.GetComponent<InputManager>().movementInput.y = 0f;
        _localPlayer.GetComponent<InputManager>().verticalInput = 0f;

        StartCoroutine(Disable());
    }

    public void EnableMovement()
    {
        _localPlayer.GetComponent<InputManager>().enabled = true;
        _localPlayer.GetComponent<PlayerLocomotion>().runningSpeed = 5f;
    }

    public void VCChangeVolume()
    {
        _localPlayer.GetComponent<AudioSource>().volume = vcSlider.value;
    }

    public void ForCoroutine()
    {
        StartCoroutine(Enable());
    }

    public IEnumerator Enable()
    {
        yield return new WaitForSeconds(0.5f);

        EnableMovement();
    }

    public IEnumerator Disable()
    {
        yield return new WaitForSeconds(0.1f);

        _localPlayer.GetComponent<InputManager>().enabled = false;
    }
}
