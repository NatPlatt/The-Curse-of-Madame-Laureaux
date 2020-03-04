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
}
