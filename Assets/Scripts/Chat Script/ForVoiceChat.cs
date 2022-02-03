using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForVoiceChat : MonoBehaviour
{
    public GameObject chatBox;
    public bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        chatBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }

    public void OnClick()
    {
        if(Input.GetMouseButtonDown(0) && isPressed == false && chatBox.activeInHierarchy == false)
        {
            chatBox.SetActive(true);
            isPressed = true;
        }
        else if (Input.GetMouseButtonDown(0) && isPressed == true && chatBox.activeInHierarchy == true)
        {
            chatBox.SetActive(false);
            isPressed = false;
        }
    }
}
