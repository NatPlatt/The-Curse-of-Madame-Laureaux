using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public GameObject respawnPoint;

    public void OnReset()
    {
        //this moves the player to the respawn point
        GetComponent<CharacterController>().enabled = false;
        gameObject.transform.position = respawnPoint.transform.position;
        GetComponent<CharacterController>().enabled = true;
    }

    public void ChangeRespawnPoint(GameObject newSpawn)
    {
        respawnPoint = newSpawn;
    }
}
