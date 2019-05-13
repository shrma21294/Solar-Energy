using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRecord : MonoBehaviour {

    public string folder="Recordings";
    public int frameRate = 25;
    public int scale = 1;

    private void Start() {
        Time.captureFramerate = frameRate;

        System.IO.Directory.CreateDirectory(folder);
    }

    private void Update() {
        string name = string.Format("{0}/shot{1:D04}.png", folder, Time.frameCount);

        ScreenCapture.CaptureScreenshot(name,scale);
    }
}
