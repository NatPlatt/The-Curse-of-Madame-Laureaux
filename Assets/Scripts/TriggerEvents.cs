
using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
           triggerEnterEvent.Invoke(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
