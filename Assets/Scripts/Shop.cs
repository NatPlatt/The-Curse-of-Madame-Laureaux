using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Collection HOcollection;
    public CoinCollection coinCollection;
    public Coins coinValue;
    public IntData HOAmount;
    public GameObject buyButton;
    public GameObject allGoneText;
    public GameObject HOsprite;
    public GameObject[] storePoints;
    public int numToBuy = 1;
    public Text purchaseAmountText;
    
    
    
    private void Start()
    {
        //buyButton.SetActive(false);
        //allGoneText.SetActive(false);
        numToBuy = HOAmount.value * coinValue.value;
        Debug.Log(  "On START: "+ HOAmount.value + "times coin value is " + numToBuy);
        //Debug.Log("collectibles list length"+ HOcollection.collectablesList.Count + "storePoints length" + storePoints.Length);
        Debug.Log("Purchase Amount is " + purchaseAmountText);
        
        
    }

    public void SeeIfBuyObjects()
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
            
            purchaseAmountText.text = "$" + numToBuy.ToString();
            Debug.Log("if the list is less than store then the purchase amount is: " + numToBuy);
            BuyObjects();
        }
    }

   public void BuyObjects()
    {
        //HOcollection.collectablesList.Count = storePoints.Length;
        numToBuy *= (storePoints.Length - HOcollection.collectablesList.Count);
        Debug.Log("store points"+ storePoints.Length+ " minus collection length" + HOcollection.collectablesList.Count + " times equals numToBuy " + numToBuy);
        HOAmount.value = storePoints.Length;

        int coinAmount = coinCollection.coinList.Count * coinValue.value ;
        coinAmount -= numToBuy;
        purchaseAmountText.text = "$" + coinAmount.ToString();
    }

    public void NoBuyObjects()
    {
        
    }
}
