using System;
using UnityEngine;

public class Screenshotter : MonoBehaviour
{
    public string DestinationFolder = "Assets//Screenshots";
    private string fullPath;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            TakeScreenshot();
        }
    }

    public void TakeScreenshot()
    {
        fullPath = DestinationFolder + "/" + GetFilename();
        Debug.Log("Taking screenshot and saving it at: " + fullPath);
        ScreenCapture.CaptureScreenshot(fullPath);
    }
    private string GetFilename()
    {
        string timestamp = DateTime.Now.ToString("dd.MM.yyyy_HH-mm-ss.ffff");
        return "WotA-" + timestamp + ".png";
    }
}