
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharController : CharBehavior
{
    public Vector3 rotateDirection;
    private float horizontalInput, verticalInput;

    private void MoveChar()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (charController.isGrounded)
        {
            if (horizontalInput != 0 && verticalInput != 0)
            {
                moveDirection.x = horizontalInput * speed;
                moveDirection.z = verticalInput * speed;
            }

            if (moveDirection.x != 0 || moveDirection.z != 0)
            {
                charController.transform.forward = new Vector3(moveDirection.x, 0, moveDirection.z);
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(moveDirection * Time.deltaTime);
    }

    public void Update() 
        {
       
            MoveChar();
            
           
            //transform.Rotate(rotateDirection);

            //moveDirection = transform.TransformDirection(moveDirection);
        }
        

        /*if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation( moveDirection),0.15f );
        }*/
        
    }

    /*void Rotate()
    {
        transform.Rotate(0, 90, 0);
    }*/

    

