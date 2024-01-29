using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float RotationSpeed = 75.0f;
    Rigidbody2D rigidbody;
    Vector2 direction;
    public float resistance = 100;

    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, -RotationSpeed * Time.deltaTime);
        rigidbody.AddForce(direction * resistance * Time.deltaTime);
    }
}
