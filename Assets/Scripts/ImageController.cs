using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image image;
    public Stats statObj;
    void Start()
    {
        image = GetComponent<Image>();
    }
    
    void UpdateImageComponent()
    {
        image.fillAmount = statObj.GetValue();
    }
}
