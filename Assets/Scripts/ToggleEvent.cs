using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class ToggleEvent : ScriptableObject
{
    public UnityEvent onEvent;
    public UnityEvent offEvent; 
    public UnityAction raise;

    public UnityAction Raise
    {
        get => raise;
        set => raise = value;
    }

    private void OnEnable()
    {
        raise = TurnOn;
    }

    public void TurnOn()
    {
        
    }
}
