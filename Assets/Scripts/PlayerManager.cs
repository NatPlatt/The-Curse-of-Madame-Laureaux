using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//keeps track of the player
public class PlayerManager : MonoBehaviour
{
    public Color killedColor = Color.black;
    #region Singleton

    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;

    public void KillPlayer()
    {
        //translate player back to starting position
        gameObject.GetComponent<Renderer>().material.color = killedColor;
    }
}
