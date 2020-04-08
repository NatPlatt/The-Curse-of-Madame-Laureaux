
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public List<GameObject> inventorySlots;

    public GameObject hiddenObjectImage, coinImage;

    public int coinCount = 0;
    public Text coinUI;

    public PickUpObj.pickUpType pickUpType;

    public void InventoryManager(GameObject pickUp)
    {
        //what pickup object is it
        pickUpType = pickUp.GetComponent<PickUpObj>.pickUps;
        //turn on that image and value in the inventory 
        AddToInventory(pickUpType);
    }
}
