using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoolEvents : MonoBehaviour
{
    public bool boolCondition = false;

    public UnityEvent trueEvent;
    public UnityEvent falseEvent;

    public void RunTheEvent()
    {
        if (boolCondition == true)
        {
            trueEvent.Invoke();
        }
        else
        {
            falseEvent.Invoke();
        }
    }

    public void ToggleBoolCondition()
    {
        boolCondition = !boolCondition;
    }

}
