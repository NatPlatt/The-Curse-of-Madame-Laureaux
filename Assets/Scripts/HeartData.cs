using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeartData : MonoBehaviour
{
    public int currentHearts;

    public UnityEvent deathEvent, onLoseHeartEvent;

    private void Update()
    {
        if (currentHearts <= 0)
        {
            deathEvent.Invoke();
        }
    }

    public void LoseHeart()
    {
        currentHearts--;
        onLoseHeartEvent.Invoke();
    }
}
