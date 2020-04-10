using System;
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
    public GameObject[] storePoints;

    private void Start()
    {
        buyButton.SetActive(false);
        allGoneText.SetActive(false);
    }

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
            buyButton.SetActive(true);
            allGoneText.SetActive(false);
        }
    }
}
