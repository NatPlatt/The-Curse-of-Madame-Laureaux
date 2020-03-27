using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public GameObject playerObj;
    public GameObject hiddenObj;
    public float hiddenObjBounds = 4;
    public float playerDistance;
    
    void Update()
    {
        playerDistance = playerObj.transform.position.x;

        if (playerDistance <= hiddenObjBounds)
        {
            Interact();
        }
    }
    
    public override void Interact()
    {
        base.Interact();
        Debug.Log("You have found hidden clue 1");
    }
    
}
