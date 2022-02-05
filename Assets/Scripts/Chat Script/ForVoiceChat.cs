using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.Unity;
using Photon.Voice.PUN;

public class ForVoiceChat : MonoBehaviour
{
    //public bool isPressed;

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
        if (view.IsMine)
        {
            OpenMic();
            CloseMic();
        }
    }

    public void OpenMic()
    {
        voiceRecorder.TransmitEnabled = true;
    }

    public void CloseMic()
    {
        voiceRecorder.TransmitEnabled = false;
    }
}
