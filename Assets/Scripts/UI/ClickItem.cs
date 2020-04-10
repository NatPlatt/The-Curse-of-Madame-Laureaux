using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{
    public GameObject canvas;

    public void OnClick()
    {
        canvas = GameObject.Find("Canvas");
        //canvas.GetComponent<QuickSelectMenu>().quickSelectTextBox.SetActive(true);
    }
}
