using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class HiddenObjCollectable : Collectable
{
    public UnityEvent useEvent;
    public float HPamount;
    public string text;

    public override void Use()
    {
        useEvent.Invoke();
    }
}
