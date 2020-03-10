using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : NameId // or could be ScriptableObject
{
    //this is a template
    public abstract void Use();
}
