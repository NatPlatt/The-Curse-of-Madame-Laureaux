
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharBehavior : MonoBehaviour
{
    protected CharacterController charController;
    private Vector3 position;
    private Vector3 movement;

    public float speed = 6.0f;
    public float rotateSpeed = 2.0f;
    public float gravity = 20.0f;

    private bool goHorizontal = false;
    
    protected Vector3 moveDirection = Vector3.zero;
    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    
}
