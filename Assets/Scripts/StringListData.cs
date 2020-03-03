using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
   public List<string> stringListObj;

   public int currentLineNumber;

   public string returnCurrentLine()
   {
      return stringListObj[currentLineNumber];
   }
}
