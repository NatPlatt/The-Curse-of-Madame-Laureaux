using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public GameObject player;
    public float hiddenObjBounds = 4;
    public float playerDistance;

    void Update()
    {
        playerDistance = player.transform.position.x;
    }
    
    public override void Interact()
    {
        if ( playerDistance <= hiddenObjBounds)
        {
             base.Interact();
             Debug.Log("You have found hidden clue 1");
        }
        
    }
}
