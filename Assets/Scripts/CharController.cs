
using System;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharController : CharBehavior
{
    public Vector3 rotateDirection;
    private float horizontalInput, verticalInput;
    Vector3 move = new Vector3(0,0,0);
    

    private void MoveChar()
    {
        if (charController.isGrounded)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            move = new Vector3(-horizontalInput, 0, -verticalInput);
            
            if (horizontalInput != 0 || verticalInput != 0)
            {
                transform.rotation = Quaternion.LookRotation(move);
            }
            else
            {
                move = new Vector3(horizontalInput,0,verticalInput);
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(speed * Time.deltaTime * moveDirection );
    }

    public void Update() 
        {
            MoveChar();
        }
        

        /*if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation( moveDirection),0.15f );
        }
        void Rotate()
        {
        transform.Rotate(0, 90, 0);
        }
    
        //transform.Rotate(rotateDirection);

        //moveDirection = transform.TransformDirection(moveDirection);*/
        
    }

    

    

