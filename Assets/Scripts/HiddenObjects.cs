﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public override void Interact()
    {
        base.Interact();
        Debug.Log("You have found hidden clue 1");
    }
}