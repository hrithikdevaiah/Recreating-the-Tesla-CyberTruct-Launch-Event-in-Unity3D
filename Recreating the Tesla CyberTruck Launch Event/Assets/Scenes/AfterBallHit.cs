using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterBallHit : MonoBehaviour
{
    public void BallButton()
    {
        SceneManager.LoadScene(4);
    }
}
