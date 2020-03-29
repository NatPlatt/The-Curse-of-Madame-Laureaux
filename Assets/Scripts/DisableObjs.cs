using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class DisableObjs : ScriptableObject
{
    public GameObject hiddenObj;
    
    public void DisableIt()
    {
        hiddenObj.SetActive(false);
    }
}
