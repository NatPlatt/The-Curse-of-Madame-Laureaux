using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public GameObject respawnPoint;

    public void OnReset()
    {
        GetComponent<CharacterController>().enabled = false;
    }
}
