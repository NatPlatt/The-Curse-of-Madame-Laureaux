using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroy : MonoBehaviour
{
    public UnityEvent BeforeDestroyEvent;
    public UnityEvent AfterDestroyEvent;

    public void DestroyThis()
    {
        BeforeDestroyEvent.Invoke();
        Destroy(gameObject);
        
        AfterDestroyEvent.Invoke();
        gameObject.SetActive(true);
    }
    
}
