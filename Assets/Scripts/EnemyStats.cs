using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharStats
{
    public Color friendColor = Color.green;
    
    
    public override void Die()
    {
        base.Die();
        
        gameObject.GetComponent<Renderer>().material.color = friendColor;
        
    }
}
