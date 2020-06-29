using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Light spotlight;
    //public float x, y, z;

    // Start is called before the first frame update
 

    void Start()
    {
        StartCoroutine(ColorChangeRoutine());
    }

    private IEnumerator ColorChangeRoutine()
    {
        while (true)
        {
            spotlight.color = new Color32(System.Convert.ToByte(Random.Range(0, 255)), System.Convert.ToByte(Random.Range(0, 255)), System.Convert.ToByte(Random.Range(0, 255)), 255);
            yield return new WaitForSeconds(0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
