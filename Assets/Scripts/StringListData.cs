
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
   public List<string> stringListObj;

   public int currentLineNumber;

   public string ReturnCurrentLine()
   {
      return stringListObj[currentLineNumber];
   }

   public void IncrementLineNumber() //this can be called in any event system like TriggerEnter or MouseButton etc.
   {
      if (currentLineNumber < stringListObj.Count)
      {
         currentLineNumber++;
      }
      else
      {
         currentLineNumber = 0;
      }
   }
}
