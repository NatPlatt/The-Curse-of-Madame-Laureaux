using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 1f;

    public Transform[] moveSpots;
    private int randomSpot;
    void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    
    void Update()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
    }
}
