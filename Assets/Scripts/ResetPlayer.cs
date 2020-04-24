using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public GameObject respawnPoint;

    public GameObject healthBar;

    public int maxHealth;

    public void OnReset()
    {
        //this moves the player to the respawn point
        GetComponent<CharacterController>().enabled = false;
        gameObject.transform.position = respawnPoint.transform.position;
        GetComponent<CharacterController>().enabled = true;
        
        //reset health
        GetComponent<CharStats>().currentHP = GetComponent<CharStats>().maxHP;
        
        //reset healthbar
        healthBar.GetComponent<HealthBar>().SetMaxHealth(maxHealth);
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        respawnPoint = newSpawn;
    }
}
