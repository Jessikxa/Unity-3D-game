using System;
//using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    public float _speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 _velocity;
    bool isGrounded;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded  && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        _characterController.Move(move * _speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        _velocity.y += gravity * Time.deltaTime;

        _characterController.Move(_velocity * Time.deltaTime);

        //Vector3 forwardCam = Camera.main.transform.forward * y;
        //Vector3 sideCam = Camera.main.transform.right * x;
        //Vector3 moveDirection = (forwardCam + sideCam) * (_speed * Time.deltaTime);

        //Vector3 Movement = new Vector3(x, 0, y) * (_speed * Time.deltaTime);
        //_characterController.Move(Movement + moveDirection);
        //_characterController.(moveDirection);

        //Debug.Log(y);
        //Debug.Log(x + y);
    }
}
