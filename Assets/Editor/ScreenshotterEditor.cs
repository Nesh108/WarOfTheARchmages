using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Screenshotter))]
public class ScreenshotterEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Screenshotter sc = (Screenshotter)target;
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Screenshot"))
        {
            sc.TakeScreenshot();
        }
    }
}