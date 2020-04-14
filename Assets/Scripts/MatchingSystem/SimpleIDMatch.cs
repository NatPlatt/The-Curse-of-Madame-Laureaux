using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatch : IdBehavior
{
    protected NameId OtherIdObj;
    public UnityEvent matchEvent, noMatchEvent;
    public virtual void OnTriggerEnter(Collider other)
    {
        OtherIdObj = other.GetComponent<NameId>();

        if (nameIdObj == OtherIdObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}


