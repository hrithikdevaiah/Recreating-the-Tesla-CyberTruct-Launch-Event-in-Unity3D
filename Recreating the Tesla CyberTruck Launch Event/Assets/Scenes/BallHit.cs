using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    //public Animator anim;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //anim.Play("BallHitAnim");
            //ball.GetComponent<Animator>().Play("BallAnim");
            anim.Play("BallAnimation");
        }
    }
}