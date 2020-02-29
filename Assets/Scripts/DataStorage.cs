using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "DataStorage", menuName = "Data Storage/Data Storage Object")]
public class DataStorage : ScriptableObject
{
    public ScriptableObject data;

    public void SetData()
    {
        if (data == null) return;
        PlayerPrefs.SetString(data.name, JsonUtility.ToJson(data));
    }

    public void GetData()
    {
        
    }
}
