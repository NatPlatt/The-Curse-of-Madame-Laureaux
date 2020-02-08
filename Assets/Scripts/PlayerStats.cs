using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharStats
{
    public override void Die()
    {
        base.Die();
        //kill the player somehow
        PlayerManager.instance.KillPlayer();
    }
}
