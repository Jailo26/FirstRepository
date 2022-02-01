using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForVoiceChat : MonoBehaviour
{
    public PushToTalk pressCheck;

    public bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        pressCheck = GetComponent<PushToTalk>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn == true)
        {
            pressCheck.enabled = true;
        }
    }

    public void OnClick()
    {
        isOn = true;
    }
}
