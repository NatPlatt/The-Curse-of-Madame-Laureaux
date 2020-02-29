﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharStats
{
    public Color friendColor = Color.green;

    public GameObject coin;
    //public ClickParticles enemyParticles;
    
    public override void Die()
    {
        base.Die();
        
        gameObject.GetComponent<Renderer>().material.color = friendColor;
        
        
        Destroy(gameObject);
       // enemyParticles.ghostPlasm.emissionRate = 0f;
       Instantiate(coin);

    }

    /*public void Update()
    {
         if (Input.GetMouseButtonDown(0))
         {
             TakeDamage(5);
         }
    }*/
}
