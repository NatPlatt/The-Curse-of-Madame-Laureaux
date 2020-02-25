using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehavior : IdBehavior
{ 
    public WorkSystemManager workSystemManagerObj; 

    private NameId otherIdObj;

    private void OnTriggerEnter(Collider other)
    {
        otherIdObj = other.GetComponent<IdBehavior>().nameIdObj;
        CheckID();
    }

    private void CheckID()
    {
        foreach (var obj in workSystemManagerObj.workIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                obj.workSystemObj.Work();
            }
        }
    }
}
