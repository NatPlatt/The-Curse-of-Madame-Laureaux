using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CoinCollection : ScriptableObject
{
    public List<Coins> coinList;

    public void AddCoin(Coins coinObj)
    {
        if (!coinList.Contains(coinObj))
        {
            coinList.Add(coinObj);
        }
    }

    public void UseCoin()
    {
        
    }

    public void UseCoinWithValue(int value)
    {
        
    }

    public void UseAllCoins()
    {
        
    }

    public void UpgradeAllCoins(int value)
    {
        
    }
}
