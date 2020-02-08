using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharStats))]
public class CharCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCoolDown = 0f; //slows down the attacks to once per frame so the enemy doesn't die too quickly
    
    private CharStats myStats;
    void Start()
    {
        myStats = GetComponent<CharStats>();
    }

    private void Update()
    {
        attackCoolDown -= Time.deltaTime;
    }

    public void Attack(CharStats targetStats)
    {
        if (attackCoolDown <= 0f)
        {
             targetStats.TakeDamage(myStats.damage.GetValue());
             attackCoolDown = 1f / attackSpeed;
        }
       
    }
}
