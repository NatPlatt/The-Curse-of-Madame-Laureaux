﻿using System;
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
    public List<PossibleWork> workIdList;

    private void OnTriggerEnter(Collider other)
    {
        otherBehaviorObj = other.GetComponent<IdBehavior>();
        if (otherBehaviorObj == null) return;
        
        otherIdObj = otherBehaviorObj.nameIdObj;
        CheckID(1);
    }

    private void OnTriggerExit(Collider other)
    {
        otherBehaviorObj = other.GetComponent<IdBehavior>();
        if (otherBehaviorObj == null) return;
        otherIdObj = otherBehaviorObj.nameIdObj;
        CheckID(2);
    }

    private void CheckID(int stateNumber)
    {
        foreach (var obj in workIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                switch (stateNumber)
                {
                    case 1: 
                        obj.EnterEvent.Invoke();
                        break;
                    case 2:
                        obj.ExitEvent.Invoke();
                        break;
                }
                
                
            }
        }
    }
}
