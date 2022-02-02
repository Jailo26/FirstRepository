using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCam : MonoBehaviour
{
    public GameObject fullScreenCamera;

    public void Start()
    {
        //fullScreenCamera.SetActive(false);
    }
    private void FixedUpdate()
    {
        CameraZoom();
    }
    public void CameraZoom()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            fullScreenCamera.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            fullScreenCamera.SetActive(false);
        }
    }
}
