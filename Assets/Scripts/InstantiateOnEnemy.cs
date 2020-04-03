using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateOnEnemy : MonoBehaviour
{
    public GameObject coin;
    public int coinNum;
    public GameObject[] coins;
    
    public void GetYourCoins()
    {
        coinNum = coins.Length;
        foreach (i in coinNum Instantiate(coin, transform.position, Quaternion.identity)) 
    }
}
