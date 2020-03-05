using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour //this is controlled by a gameAction object
{
    private Text textObj;
    //public StringListData stringListDataObj;
    public UnityEvent awakeEvent;

    void Awake()
    {
        textObj = GetComponent<Text>();
        awakeEvent.Invoke();
    }
    
    void UpdateStringData(StringListData stringListDataObj)
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }

    public void UpdateText(IntData intDataObj)
    {
        textObj.text = intDataObj.value.ToString();
    }
}
