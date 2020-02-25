using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : IdBehavior
{
    // public WorkSystemManager WorkSystemManagerObj; write script for this

    private NameId otherIdObj;

    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IdBehavior>().nameIdObj;
        CheckID();
    }
    
    
}
