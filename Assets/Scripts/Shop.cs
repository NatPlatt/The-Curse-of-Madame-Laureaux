using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Collection HOcollection;
    public IntData coinAmount;
    public IntData HOAmount;
    public GameObject buyButton;
    public GameObject allGoneText;
    public GameObject HOsprite;
    public GameObject[] storePoints;
    public int numToBuy;
    public Text purchaseAmountText;
    
    
    private void Start()
    {
        buyButton.SetActive(false);
        allGoneText.SetActive(false);
        numToBuy = HOAmount.value * 20;
    }

    void SeeIfBuyObjects()
    {
        if (HOcollection.collectablesList.Count == storePoints.Length)
        {
            buyButton.SetActive(false);
            allGoneText.SetActive(true);
            NoBuyObjects();
            return;
        }
        if (HOcollection.collectablesList.Count < storePoints.Length)
        {
            buyButton.SetActive(true);
            allGoneText.SetActive(false);
            BuyObjects();
        }
    }

    void BuyObjects()
    {
        purchaseAmountText.text = "$" + numToBuy.ToString();
        
    }

    void NoBuyObjects()
    {
        
    }
}
