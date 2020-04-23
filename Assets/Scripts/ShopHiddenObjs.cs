using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopHiddenObjs : MonoBehaviour
{
    public Collection HOcollection;
    public Collectable HObject;
    public Button hiddenObjButton;
    public List<Collectable> hiddenObjSOs;
    public GameObject[] buttons;
    
    public void IsActive()
    {
        if (HOcollection.collectablesList.Count <= hiddenObjSOs.Count)
        {
            for (int i = 0; i < HOcollection.collectablesList.Count; i ++ )
            {
                gameObject.SetActive(hiddenObjButton);
                Debug.Log("the buttons should be active");
            }
        }
    }
}
