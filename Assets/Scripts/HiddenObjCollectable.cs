using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class HiddenObjCollectable : Collectable
{
    public UnityEvent useEvent;
    public float HPamount;

    public override void Use()
    {
        useEvent.Invoke();
    }
}
