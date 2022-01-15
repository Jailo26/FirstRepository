using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ThirdPersonCharacterController : MonoBehaviour
{
    public float speed;

    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    public void Update()
    {
        if (view.IsMine)
        {
            PlayerMovement();
        }          
    }

    public void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}
