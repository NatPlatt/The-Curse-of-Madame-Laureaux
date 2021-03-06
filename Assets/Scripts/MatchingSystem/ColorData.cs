﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ColorData : NameId
{
   public Color value = Color.blue;

   public void ChangeSpriteRenderColor(SpriteRenderer spriteRendererObj)
   {
      spriteRendererObj.color = value;
   }

   public void ChangeSpriteRenderColor(SpriteRendererController spriteRendererController)
   {
      spriteRendererController.spriteRendererObj.color = value;
   }
}
