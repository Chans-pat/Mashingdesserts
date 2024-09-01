using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class exit : MonoBehaviour
{
    public static string webplayerQuitURL = "Http://google.com";

    public void Quit()
    {
#if  UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
#if UNITY_WEBPLAYER
        Application.OpenURL(webplayerQuitURL);
#endif
        Application.Quit();
    }
}
