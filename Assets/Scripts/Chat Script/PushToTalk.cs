using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.Unity;
using Photon.Voice.PUN;

public class PushToTalk : MonoBehaviourPun
{
    public KeyCode pushButton = KeyCode.P;
    public Recorder voiceRecorder;
    private PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        voiceRecorder.TransmitEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pushButton))
        {
            if(view.IsMine)
            {
                voiceRecorder.TransmitEnabled = true;
            }
        }
        else if(Input.GetKeyUp(pushButton))
        {
            if(view.IsMine)
            {
                voiceRecorder.TransmitEnabled = false;
            }
        }
    }

}
