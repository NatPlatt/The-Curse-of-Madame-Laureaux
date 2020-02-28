using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Coins : ScriptableObject
{
    public UnityAction<int> coinAction;

    public int value = 10;

    public void Spend()
    {
        coinAction?.Invoke(value);
    }
}
