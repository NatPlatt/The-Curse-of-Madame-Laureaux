using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public Transform playerTransform;
    public GameObject player;
    public float hiddenObjBounds = 4;
    public float distance;
   
    protected void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, transform.position);
    }
    
    public override void Interact()
    {
        if (distance <= hiddenObjBounds)
        {
             base.Interact();
             Debug.Log("You have found hidden clue 1");
        }
        
    }
}
