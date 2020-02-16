using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharStats
{
    public EnemyStats enemyStat;
    public Color deadColor = Color.black;
    public Color dangerColor = Color.yellow;
    
    public override void Die()
    {
        base.Die();
        //kill the player somehow
        gameObject.GetComponent<Renderer>().material.color = deadColor;
            PlayerManager.instance.KillPlayer();
    }

   private void OnTriggerEnter(Collider other)
   {
       gameObject.GetComponent<Renderer>().material.color = dangerColor;
       Debug.Log("You are in danger Player");
   }

   private void OnTriggerExit(Collider other)
   {
       gameObject.GetComponent<Renderer>().material.color = Color.white;
   }
}
