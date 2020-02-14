using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action;
    public UnityAction<Transform> transformAction;
    public object call;

    public void Raise()
    {
        if (action != null)
        {
            action.Invoke();
        }
    }

    public void Raise(Transform transformObj)
    {
        if (transformAction != null)
        {
            transformAction.Invoke(transformObj);
        }
    }
}
