using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    float acceeleration;
    float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
       
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        acceeleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");


    }

    private void FixedUpdate()
    {
        
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceeleration * forwardSpeed * Time.deltaTime;
        rigidbody.AddForce(force);


    }


}
