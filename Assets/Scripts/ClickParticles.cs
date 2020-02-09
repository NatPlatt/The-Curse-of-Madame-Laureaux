using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickParticles : MonoBehaviour
{
    public ParticleSystem ghostPlasm;


    private void Start()
    {
        ghostPlasm = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ghostPlasm.emissionRate = 50f;
        }
        else
        {
            ghostPlasm.emissionRate = 0f;
        }
    }
}
