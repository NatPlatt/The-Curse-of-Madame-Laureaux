using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObj : MonoBehaviour
{

    public GameObject inventory;
    public pickUpType pickUps;

    public enum pickUpType
    {
        COINS, HIDDENOBJS
    }

    public void TalkToInventory()
    {
        inventory = GameObject.Find("Canvas");

        inventory.GetComponent<InventoryUI>().InventoryManager(gameObject);
    }

    /*public GameObject pickUpObj;
    public GameObject holdObj;

    public void PickUpSomething()
    {
        pickUpObj.transform.position = holdObj.transform.position;
        pickUpObj.transform.SetParent(holdObj.transform);
    }*/
}
