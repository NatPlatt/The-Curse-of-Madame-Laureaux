using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnemyPoint : MonoBehaviour
{
    public static Action<Transform> SendTransformAsPoint;
    void Start()
    {
        if (SendTransformAsPoint != null)
        {
            SendTransformAsPoint(transform);
        }
    }

    
    void Update()
    {
        
    }
}
