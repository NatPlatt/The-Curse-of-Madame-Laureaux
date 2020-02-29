using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class ToggleEvent : ScriptableObject
{
    public UnityEvent onEvent;
    public UnityEvent offEvent;
    public UnityAction raise;
    
    
}
