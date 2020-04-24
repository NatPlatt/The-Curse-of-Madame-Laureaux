using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsUI : MonoBehaviour
{
    public GameObject heartOne, heartTwo, heartThree, heartFour, heartFive;
    public HeartData heartData;

    public void DisplayHearts()
    {
        if (heartData.currentHearts == 5)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
            heartFour.SetActive(true);
            heartFive.SetActive(true);
        }
        
        if (heartData.currentHearts == 4)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
            heartFour.SetActive(true);
            heartFive.SetActive(false);
        }
        
        if (heartData.currentHearts == 3)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(true);
            heartFour.SetActive(false);
            heartFive.SetActive(false);
        }
        
        if (heartData.currentHearts == 2)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(true);
            heartThree.SetActive(false);
            heartFour.SetActive(false);
            heartFive.SetActive(false);
        }
        
        if (heartData.currentHearts == 1)
        {
            heartOne.SetActive(true);
            heartTwo.SetActive(false);
            heartThree.SetActive(false);
            heartFour.SetActive(false);
            heartFive.SetActive(false);
        }
        
        if (heartData.currentHearts == 0)
        {
            heartOne.SetActive(false);
            heartTwo.SetActive(false);
            heartThree.SetActive(false);
            heartFour.SetActive(false);
            heartFive.SetActive(false);
        }
    }
}
