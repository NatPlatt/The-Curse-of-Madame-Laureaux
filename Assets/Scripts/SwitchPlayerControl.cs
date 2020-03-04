using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControl : MonoBehaviour
{
    public GameObject avatarActive1, avatarActive2, avatarInactive1, avatarInactive2;

    private int activeAvatar = 1;

    private void Start()
    {
        avatarActive1.gameObject.SetActive(true);
        avatarActive2.gameObject.SetActive(false);
        
        avatarInactive1.gameObject.SetActive(false);
        avatarInactive2.gameObject.SetActive(true);
    }

    public void SwitchControl()
    {
        switch (activeAvatar)
        {
            case 1:
                activeAvatar = 2;
                
                avatarActive1.gameObject.SetActive(false);
                avatarActive2.gameObject.SetActive(true);
                
                avatarInactive1.gameObject.SetActive(true);
                avatarInactive2.gameObject.SetActive(false);
                break;
            
            case 2:
                activeAvatar = 1;
                
                avatarActive1.gameObject.SetActive(true);
                avatarActive2.gameObject.SetActive(false);
                
                avatarInactive1.gameObject.SetActive(false);
                avatarInactive2.gameObject.SetActive(true);
                break;
        }
    }
}
