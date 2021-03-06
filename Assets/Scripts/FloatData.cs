﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 1f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    private void UpdateValueLimitZero(float amount)
    {
        if (value > 0)
        {
            UpdateValue(amount);
        }
        else
        {
            value = 0;
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amount)
    {
        if (value <= maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
        UpdateValueLimitZero(amount);
    }

    public void ChangeAmount(float amount)
    {
        value = amount;
    }

    public float GetValue()
    {
        float finalValue = value;
        return finalValue;
    }
}
