using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP { get; private set; }
    
    public Stats damage;

    private void Awake()
    {
        currentHP = maxHP;
    }
}
