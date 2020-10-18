using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private int width, height;
    private Rect rect;
    private GUIStyle labelStyle;
    private string currentTime;


    void Start()
    {
        width = Screen.width;
        height = Screen.height;
        rect = new Rect(10, 10, width - 20, height - 20);
        GameObject obj = GameObject.Find("Timer");
        Timer myTimer = (Timer) obj.GetComponent(typeof(Timer));
        currentTime = myTimer.getElapsedTime();
    }

    void OnGUI()
    {
        // Display the label at the center of the window.
        labelStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        labelStyle.alignment = TextAnchor.UpperCenter;

        // Modify the size of the font based on the window.
        labelStyle.fontSize = 10 * (width / 200);

        // Display the current time.
        GUI.Label(rect, currentTime, labelStyle);
    }
}
