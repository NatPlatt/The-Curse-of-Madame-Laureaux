using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayerControl : MonoBehaviour
{
    public GameObject avatarActive1, avatarActive2, avatarInactive1, avatarInactive2;

    public Transform currentPlayerPosition, currentEnemyPosition;

    private int activeAvatar = 1;

    private void Start()
    {
       

        currentPlayerPosition = avatarActive1.transform;
        currentEnemyPosition = avatarActive2.transform;
    }

    public void SwitchControl()
    {
        switch (activeAvatar)
        {
            case 1:
                activeAvatar = 2;

                avatarActive1.GetComponent<CharController>().enabled = false;
                avatarActive2.GetComponent<CharController>().enabled = true;

                //avatarInactive1.gameObject.transform = currentEnemyPosition;

               //avatarInactive1.gameObject.SetActive(true);
                //avatarInactive2.gameObject.SetActive(false);
                break;
            
            case 2:
                activeAvatar = 1;
                
                avatarActive1.GetComponent<CharController>().enabled = true;
                avatarActive2.GetComponent<CharController>().enabled = false;
                
                //avatarInactive1.gameObject.SetActive(false);
               // avatarInactive2.gameObject.SetActive(true);
                break;
        }
    }
}
