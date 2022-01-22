using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerLocomotion playerLocomotion;
    PhotonView view;

    private void Awake()
    {
        view = GetComponent<PhotonView>();
        inputManager = GetComponent<InputManager>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void Update()
    {
        if(view.IsMine)
        {
            inputManager.HandleAllInputs();
        }       
    }

    private void FixedUpdate()
    {
        if(view.IsMine)
        {
            playerLocomotion.HandleAllMovement();
        }
    }

    private void LateUpdate()
    {
        cameraManager.HandleAllCameraMovement();
    }
}
