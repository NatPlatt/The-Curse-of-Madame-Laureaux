using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharStats))]
public class CharCombat : MonoBehaviour
{
    private CharStats myStats;
    void Start()
    {
        myStats = GetComponent<CharStats>();
    }

    public void Attack(CharStats targetStats)
    {
        targetStats.TakeDamage(20);
    }
}
