using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObj : MonoBehaviour
{

    public GameObject inventory;

    public enum pickUpType
    {
        COINS, HIDDENOBJS
    }

    /*public GameObject pickUpObj;
    public GameObject holdObj;

    public void PickUpSomething()
    {
        pickUpObj.transform.position = holdObj.transform.position;
        pickUpObj.transform.SetParent(holdObj.transform);
    }*/
}
