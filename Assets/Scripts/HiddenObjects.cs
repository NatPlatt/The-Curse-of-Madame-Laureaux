using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public Canvas canvasObj;

    private void Start()
    {
        canvasObj.enabled = false;
    }

    public override void Interact()
    {
        base.Interact();
        Debug.Log("You have found hidden clue 1");
        canvasObj.enabled = true;
    }

}
