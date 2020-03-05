using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/IntData")]
public class IntData : NameId
{
   public int value;

   public void SetValue(int amount)
   {
      value = amount;
   }

   public void UpdateValue(int amount)
   {
      value += amount;
   }
}
