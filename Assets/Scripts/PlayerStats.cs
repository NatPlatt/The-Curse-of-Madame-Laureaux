using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : CharStats
{
    public EnemyStats enemyStat;
    public Color deadColor = Color.black;
    
    

    public override void Die()
    {
        base.Die();
        if (maxHP <= 0)
        {
            SceneManager.LoadScene("KillScreen");
        }
        gameObject.GetComponent<Renderer>().material.color = deadColor;
            PlayerManager.instance.KillPlayer();
    }
    
    
  
}
