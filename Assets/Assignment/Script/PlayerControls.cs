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
    public float speedMax;
    public float carForce = 1000;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        move = Input.GetAxis("Vertical");
        turn = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {

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
        Debug.Log("The Player has hit something");
    }
}
