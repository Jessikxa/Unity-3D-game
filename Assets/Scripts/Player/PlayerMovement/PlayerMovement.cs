using System;
//using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _characterController;
    public float _speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 forwardCam = Camera.main.transform.forward * y;
        Vector3 sideCam = Camera.main.transform.right * x;
        Vector3 moveDirection = (forwardCam + sideCam) * (_speed * Time.deltaTime);

        Vector3 Movement = new Vector3(x, 0, y) * (_speed * Time.deltaTime); 
        _characterController.Move(Movement +  moveDirection);
        //_characterController.(moveDirection);

        //Debug.Log(y);
        //Debug.Log(x + y);
    }
}
