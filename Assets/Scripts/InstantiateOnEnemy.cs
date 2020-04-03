using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InstantiateOnEnemy : ScriptableObject
{
    public GameObject coin;
    public Transform transform;

    public void GetYourCoins()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}
