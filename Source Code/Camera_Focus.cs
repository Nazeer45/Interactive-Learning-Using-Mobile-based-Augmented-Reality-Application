using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Camera_Focus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += StartVuforiaFocus;
        //VuforiaApplication.Instance.OnVuforiaPaused += OnPaused;
    }

    public void StartVuforiaFocus()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        VuforiaBehaviour.Instance.CameraDevice.SetCameraMode(Vuforia.CameraMode.MODE_DEFAULT);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
