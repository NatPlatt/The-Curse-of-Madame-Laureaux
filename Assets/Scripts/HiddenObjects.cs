using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public GameObject hiddenObj; 
    public override void Interact()
    {
        base.Interact();
        Debug.Log("You have found hidden clue 1");
        
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        gameObject.GetComponent<Renderer>().material.color = clickedColor;
    }
    
}
