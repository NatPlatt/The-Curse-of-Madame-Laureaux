using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOButtons : MonoBehaviour
{
    public HiddenObjCollectable hiddenObj;
    
    public void AddHealthToPlayer()
    {
        GetComponent<PlayerStats>().maxHP += hiddenObj.playerHPamount;
    }

    public void TakeAwayEnemyHealth()
    {
        GetComponent<EnemyStats>().maxHP -= hiddenObj.enemyHPamount;
    }
}
