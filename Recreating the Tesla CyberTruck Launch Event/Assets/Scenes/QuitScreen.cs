using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScreen : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void BQuit()
    {
        Application.Quit();
    }
}
