using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUpControl : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonQuit()
    {
        Application.Quit();
    }
}
