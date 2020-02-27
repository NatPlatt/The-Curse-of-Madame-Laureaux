using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteRenderBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRendererObj;
    public UnityEvent startEvent;
    void Start()
    {
        spriteRendererObj = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
