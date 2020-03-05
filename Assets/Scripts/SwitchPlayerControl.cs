using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControl : MonoBehaviour
{
    public GameObject avatarActive1, avatarActive2;

    private int activeAvatar = 1;
    

    public void SwitchControl()
    {
        switch (activeAvatar)
        {
            case 1:
                activeAvatar = 2;

                avatarActive1.GetComponent<CharController>().enabled = false;
                avatarActive2.GetComponent<CharController>().enabled = true;
                
                break;
            
            case 2:
                activeAvatar = 1;
                
                avatarActive1.GetComponent<CharController>().enabled = true;
                avatarActive2.GetComponent<CharController>().enabled = false;
                
                break;
        }
    }
}
