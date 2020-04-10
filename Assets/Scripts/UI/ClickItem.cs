using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{
    public GameObject canvas;

    public void OnClick()
    {
        canvas = GameObject.Find("Canvas");
        canvas.GetComponent<QuickSelectMenu>().quickSelectBox.SetActive(true);
    }
}

public class QuickSelectMenu : MonoBehaviour
{
    public GameObject quickSelectBox;
    public GameObject hiddenObjButton;
}


