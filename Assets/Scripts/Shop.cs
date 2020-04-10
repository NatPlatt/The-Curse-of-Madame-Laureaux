using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public Collection HOcollection;
    public IntData coinAmount;
    public IntData HOAmount;
    public GameObject buyButton;
    public GameObject allGoneText;
    public GameObject HOsprite;
    public Transform[] storePoints;
    
    void BuyObjects()
    {
        if (HOcollection.collectablesList.Count == HOAmount.value)
        {
            buyButton.SetActive(false);
            allGoneText.SetActive(true);
            return;
        }
        if (HOcollection.collectablesList.Count < HOAmount.value)
        {
            Instantiate(HOsprite, storePoints, Quaternion.identity);
        }
    }
}
