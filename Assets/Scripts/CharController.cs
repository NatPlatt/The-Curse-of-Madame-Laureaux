


using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharController : CharBehavior
{
    public Vector3 rotateDirection;
    private float horizontalInput, verticalInput;
    Vector3 move = new Vector3(0,0,0);
    

    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.z = speed * Input.GetAxis("Vertical");
        position.y -= gravity;
        
        /*float horizontalNum = Input.GetAxis("Horizontal");
        float verticalNum = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(0,0,0);*/
        
        if (charController.isGrounded)
        {
            position.y = 0;

            if (position != Vector3.zero)
            {
                charController.transform.forward = position;
            }

            /*move = new Vector3(-horizontalInput, 0, -verticalInput);
            if (horizontalNum != 0 || verticalNum != 0)
            {
                transform.rotation = Quaternion.LookRotation(move);
                
            }
            else
            {
                move = new Vector3(-horizontalInput,verticalInput,0);
            }*/

        }
        moveDirection.y -= gravity * Time.deltaTime;

        charController.Move(position* Time.deltaTime );
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

    

    

