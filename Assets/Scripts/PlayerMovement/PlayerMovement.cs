using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _characterController;
    public float _speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Horizontal");
        //Input.GetAxis("Vertical");

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(-y, 0, x);
        _characterController.Move(Movement * Time.deltaTime * _speed);

        //Debug.Log(y);
        Debug.Log(x + y);
    }
}
