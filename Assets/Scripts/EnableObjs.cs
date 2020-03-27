using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObjs : MonoBehaviour
{
   public MeshRenderer hiddenObjRenderer;

   private void Start()
   {
      hiddenObjRenderer.enabled = false;
   }

   private void OnTriggerEnter(Collider other)
   {
      hiddenObjRenderer.enabled = true;
   }
}
