using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Reset : MonoBehaviour
{
    public GameObject playerObj;
    public float minHeightForReset;
    public Transform respawnPosition;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (playerObj.transform.position.y < minHeightForReset)
        {
            playerObj.transform.position = respawnPosition.position;
        }
    }
}
