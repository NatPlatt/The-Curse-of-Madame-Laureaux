using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DisableObjs : ScriptableObject
{
    public GameObject disableThisObj;
    
    public void DisableIt()
    {
        disableThisObj.SetActive(false);
    }
}
