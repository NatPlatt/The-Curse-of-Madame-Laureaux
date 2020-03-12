
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharController : CharBehavior
{

    private void Update()
    {
        if (charController.isGrounded)
        {
            moveDirection.Set(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")); 
            moveDirection *= speed;
           
        }
        moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(moveDirection * Time.deltaTime);

        /*if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation( moveDirection),0.15f );
        }*/


        
        
        
    }

    /*void Rotate()
    {
        transform.Rotate(0, 90, 0);
    }*/

    
}
