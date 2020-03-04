using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIDBehavior : IdBehavior
{ 
   [Serializable]
   public struct PossibleWork
   {
       public NameId nameIdObj;
       public UnityEvent EnterEvent, ExitEvent;
   }

    private NameId otherIdObj;
    private IdBehavior otherBehaviorObj; 

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
                obj.workEvent.Invoke();
            }
        }
    }
}
