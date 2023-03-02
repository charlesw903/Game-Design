using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 5.0f;
    private float horizontalInput = 10.0f;
    private float forwardInput;
    private float jumpInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");

        //Moves the car forward based on horizontal input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car based on vertical input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * speed * horizontalInput);
        //Makes the car jump based on input
        transform.Translate(Vector3.up * Time.deltaTime * speed * jumpInput);

    }
}
