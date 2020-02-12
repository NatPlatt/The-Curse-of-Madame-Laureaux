using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalBallSwitches : MonoBehaviour
{
    public object crystalBall1;
    public object crystalBall2;
    public object crystalBall3;

    private Animator myAnimator;

    private void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //myAnimator.SetTrigger("clicked") <-- will later animate when clicked, while also triggering other anims
        }
    }
}
