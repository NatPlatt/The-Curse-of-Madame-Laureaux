using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HiddenObjCollectable : Collectable
{
    public UnityEvent useEvent;

    public override void Use()
    {
        useEvent.Invoke();
    }
}
