
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
    public IntData coinAmount;
    public IntData hiddenObjAmount;
    public Text coinUI;
    public Text hiddenObjUI;

    public PickUpObj.pickUpType pickUpType;

    public GameObject hiddenObjButtonPrefab;
    public GameObject inventoryUI;

    private void Start()
    {
        coinUI.text = "$" + coinAmount.value.ToString();
        hiddenObjUI.text = hiddenObjAmount.value.ToString();
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
            coinUI.text = "$" + coinAmount.value.ToString();
            Debug.Log("You get" + coinAmount.value + "coins");
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
            hiddenObjUI.text = hiddenObjAmount.value.ToString();
            buttonToAdd = hiddenObjButtonPrefab;
            //instantiate prefab and put it in the inventory
            inventoryButtons[index] =
                Instantiate(buttonToAdd, inventorySlots[index].transform.position, Quaternion.identity);
            //make prefab appear in the inventory menu
            inventoryButtons[index].transform.SetParent(inventoryUI.transform);
        }
    }
}
