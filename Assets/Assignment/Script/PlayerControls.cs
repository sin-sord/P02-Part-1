using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    float move;
    float turn;
    public float speedMovement = 950;
    public float turnSpeed = 400;
    public Rigidbody2D rigidbody;
    public float speedMax = 1500;
    public float carForce = 200;

    // Start is called before the first frame update
    void Start()
    {
        // this calls on the Rigidbody2D on Unity so that the player can have the rigidbody be the reason for collision
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // this tells what each variables value is
        move = Input.GetAxis("Vertical");
        turn = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {

        // adds speed to the player when turning, driving, and adds force to the player to be able to push objects
        rigidbody.AddTorque(turn * -turnSpeed * Time.deltaTime);
        Vector2 force = transform.up * move * speedMovement * Time.deltaTime;
        rigidbody.AddForce(move * turn *  force * Time.deltaTime);

       if(rigidbody.velocity.magnitude < speedMovement) 
        {
        
        rigidbody.AddForce(force);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // sends a message to tell if the player is colliding with objects
        Debug.Log("The Player has hit something");
    }
}
