using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOButtons : MonoBehaviour
{
    public HiddenObjCollectable hiddenObj;
    public PlayerStats playerStats;
    public EnemyStats enemyStats;
    
    public void AddHealthToPlayer()
    {
        playerStats = GetComponent<PlayerStats>();
        playerStats.maxHP += hiddenObj.playerHPamount;
    }

    public void TakeAwayEnemyHealth()
    {
        enemyStats = GetComponent<EnemyStats>();
        enemyStats.maxHP -= hiddenObj.enemyHPamount;
    }
}
