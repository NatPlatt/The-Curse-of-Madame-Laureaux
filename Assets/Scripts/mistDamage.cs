using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MistDamage : CharStats
{
    public HealthBar healthBar;
    public int currentHP { get; set; }
    public override void MistDamageAttack()
    {
        
        base.MistDamageAttack();
        currentHP -= mistDamage;
        healthbar.SetHealth(currentHP);
        Debug.Log("the mist is attacking");
        
    }
}
