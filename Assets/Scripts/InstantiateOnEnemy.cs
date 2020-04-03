using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateOnEnemy : MonoBehaviour
{
    public GameObject coin;
    public int coinNum;
    public GameObject[] coinsList;
    
    public void GetYourCoins()
    {
        coinNum = coinsList.Length;
        foreach (GameObject coin in coinsList)
        {
            Instantiate(coin, transform.position, Quaternion.identity);
        }
    }
}
