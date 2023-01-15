using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void OnExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
