using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObjs : MonoBehaviour
{
   public GameObject hiddenObj;

   private void Start()
   {
      hiddenObj.SetActive(false);
   }

   private void OnTriggerEnter(Collider other)
   {
      hiddenObj.SetActive(true);
   }
}
