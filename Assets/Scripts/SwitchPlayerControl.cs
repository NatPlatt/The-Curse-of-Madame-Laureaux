using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControl : MonoBehaviour
{
    public GameObject avatar1, avatar2;

    private int activeAvatar = 1;

    private void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
    }

    public void SwitchControl()
    {
        switch (activeAvatar)
        {
            case 1:
                activeAvatar = 2;
                
                avatar1.gameObject.SetActive(false);
                avatar2.gameObject.SetActive(true);
                break;
            
            
        }
    }
}
