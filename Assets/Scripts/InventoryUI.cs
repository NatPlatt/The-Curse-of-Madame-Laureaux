﻿
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public List<GameObject> inventorySlots;
    public List<GameObject> inventoryButtons;

    public GameObject hiddenObjectImage, coinImage;

    public int coinCount = 0;
    //public IntData coinAmount;
    //public IntData hiddenObjAmount;
    public Collection HOcollection;
    public CoinCollection coinCollection;
    public Coins coinValue;
    public int realCoinAmount;
    
    public Text coinUI;
    public Text hiddenObjUI;

    public PickUpObj.pickUpType pickUpType;

    public GameObject hiddenObjButtonPrefab;
    public GameObject inventoryUI;

    private void Start()
    {
        realCoinAmount = coinValue.value * coinCollection.coinList.Count;
        coinUI.text = "$" + realCoinAmount.ToString();
        hiddenObjUI.text = HOcollection.collectablesList.Count.ToString();
    }

    private void FixedUpdate()
    { 
        realCoinAmount = coinValue.value * coinCollection.coinList.Count;
       coinUI.text = "$" + realCoinAmount.ToString();
       hiddenObjUI.text = HOcollection.collectablesList.Count.ToString();
    }

    public void InventoryManager(GameObject pickUp)
    {
        //what pickup object is it
        pickUpType = pickUp.GetComponent<PickUpObj>().pickUps;
        //turn on that image and value in the inventory 
        AddToInventory(pickUpType);
    }

    public void AddToInventory(PickUpObj.pickUpType type)
    {
        if (type == PickUpObj.pickUpType.COINS)
        {
            
            //coinCount = coinAmount.value;
            coinUI.text = "$" + coinCollection.coinList.Count.ToString();
            Debug.Log("You get" + coinCollection.coinList.Count + "coins");
            return;
        }
        
        //find an empty slot in the inventory
        int index = 0;
        for (int i = 0; i < inventoryButtons.Count; i++)
        {
            if (inventoryButtons[i] == null)
            {
                index = i;
                break;
            }
        }

        GameObject buttonToAdd = null;
        if (type == PickUpObj.pickUpType.HIDDENOBJS)
        {
            hiddenObjUI.text = HOcollection.collectablesList.Count.ToString();
            buttonToAdd = hiddenObjButtonPrefab;
            //instantiate prefab and put it in the inventory
            inventoryButtons[index] =
                Instantiate(buttonToAdd, inventorySlots[index].transform.position, Quaternion.identity);
            //make prefab appear in the inventory menu
            inventoryButtons[index].transform.SetParent(inventoryUI.transform);
        }
    }
}
