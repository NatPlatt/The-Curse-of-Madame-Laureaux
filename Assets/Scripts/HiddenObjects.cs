using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObjects : Interactable
{
    public GameObject player;
    
    public override void Interact()
    {
        if (player.transform <= )
        base.Interact();
        Debug.Log("You have found hidden clue 1");
    }
}
