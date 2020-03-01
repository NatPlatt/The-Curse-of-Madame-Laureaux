using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Instancing/Instance Object")]
public class InstanceObject : ScriptableObject
{
    public int instanceAmount = 4; 
    
    public void CreateInstance(GameObject instance)
    {
        for (int i = 0; i < instanceAmount; i++)
        {
           Instantiate(instance); 
        }
        
    }
}

