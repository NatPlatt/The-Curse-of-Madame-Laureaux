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
    public CoinCollection coins;
    public IntData HOAmount;
    public GameObject allGoneText;
    public GameObject shopCanvas;
    public GameObject noMoney;
    public int numToBuy = 1;
    public Text purchaseAmountText;
    public Collectable HObject;
    public Button hiddenObjButton;
    
    
    private void Start()
    {
        //buyButton.SetActive(false);
        //allGoneText.SetActive(false);
        numToBuy = HOAmount.value * coinValue.value;
        Debug.Log(  "On START: "+ HOAmount.value + "times coin value" + coinValue.value + " is (numToBuy) " + numToBuy);
        //Debug.Log("collectibles list length"+ HOcollection.collectablesList.Count + "storePoints length" + storePoints.Length);
    }

    private void Update()
    {
        
    }

    public void SeeIfBuyObjects()
    {
        if (HOcollection.collectablesList.Count == 7)
        {
            shopCanvas.SetActive(false);
            allGoneText.SetActive(true);
            NoBuyObjects();
            return;
        }
        if (HOcollection.collectablesList.Count < 7)
        {
            shopCanvas.SetActive(true);
            allGoneText.SetActive(false);
            Debug.Log("SeeIfBuyObjects() numToBuy = " +numToBuy);
            
            //purchaseAmountText.text = "$" + numToBuy.ToString();
            //Debug.Log("if the list is less than store then the purchase amount is: " + numToBuy);
            BuyObjects();
        }
    }

   public void BuyObjects()
    {
        /*HOcollection.collectablesList.Count = storePoints.Length;
        numToBuy *= (storePoints.Length - HOcollection.collectablesList.Count);
        Debug.Log("store points length: "+ storePoints.Length+ " minus collection length: " + HOcollection.collectablesList.Count + " times equals numToBuy " + numToBuy);
        HOAmount.value = storePoints.Length;

        //int coinAmount = coinCollection.coinList.Count * coinValue.value ;
        //coinAmount -= numToBuy;
        purchaseAmountText.text = "$" + numToBuy.ToString();*/
        
        if (coins.coinList.Count <= 0)
        {
            shopCanvas.SetActive(false);
            noMoney.SetActive(true);
        }

        
    }

   public void PurchaseMade()
   {
       numToBuy -= coinValue.value;
       purchaseAmountText.text = "$" + numToBuy.ToString();
   }
    public void NoBuyObjects()
    {
        
    }

    public void IsActive()
    {
        if (HOcollection.collectablesList.Contains(HObject))
        {
            gameObject.SetActive(hiddenObjButton);
        }
    }
}
