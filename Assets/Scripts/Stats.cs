using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class Stats :ScriptableObject
{
   [SerializeField] private float baseValue;

   public float GetValue()
   {
      float finalValue = baseValue;
      return finalValue;
   }
}
