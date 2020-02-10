using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private CharacterController charController;
    private Vector3 position;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float rotateSpeed = 2.0f;
    public float gravity = 20.0f;
    
    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (charController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            
            if (position != Vector3.zero)
            {
                charController.transform.forward = position;
            }
        }

        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        

        moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(moveDirection * Time.deltaTime);
        
        
    }

    
}
