using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public Transform target, playerTransform;
    float mouseX, mouseY;

    PhotonView camView;

    // Start is called before the first frame update
    public void Start()
    {
        camView = GetComponent<PhotonView>();
    }

    public void LateUpdate()
    {
        if(camView.IsMine)
        {
            CamControl();
        }
        
    }

    public void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }
        else
        {
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            playerTransform.rotation = Quaternion.Euler(0, mouseX, 0);
        }
        
    }

}
