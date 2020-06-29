using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch3to4 : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadSceneAsync(4);        
    }
}
