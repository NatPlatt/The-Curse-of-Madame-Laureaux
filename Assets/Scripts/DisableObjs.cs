using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class DisableObjs : ScriptableObject
{
    public Text text;
    public Button button;
    
    public void DisableIt()
    {
        text.enabled = false;
        button.enabled = false;
    }
}
