using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{

    float acceeleration;
    float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 100;
    Rigidbody2D rigidbody;
    public float maxSpeed = 550;

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

        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);

        }
        

    }


}
