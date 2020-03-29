using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DisableObjs : ScriptableObject
{
    public Canvas disableThisCanvas;
    
    public void DisableIt()
    {
        disableThisCanvas.enabled = false;
    }
}
