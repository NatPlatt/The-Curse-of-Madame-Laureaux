using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharStats))]
public class Enemy : Interactable
{
    private PlayerManager playerManager;
    private CharStats myStats;
    private void Start()
    {
        playerManager = PlayerManager.instance;
    }

    public override void Interact()
    {
        base.Interact();
        CharCombat playerCombat = playerManager.player.GetComponent<CharCombat>();

        if (playerCombat != null)
        {
            playerCombat.Attack(myStats);
        }
        Debug.Log("you are attacking the enemy");
    }
}
