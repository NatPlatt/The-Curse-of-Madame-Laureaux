using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopHiddenObjs : MonoBehaviour
{
    public Collection HOcollection;
    public Collectable HObject;
    public Button hiddenObjButton;
    
    
    public void IsActive()
    {
        if (HOcollection.collectablesList.Contains(HObject))
        {
            //gameObject.SetActive(hiddenObjButton);
            //hiddenObjButton.gameObject.SetActive(false);
            
        }
    }
}
