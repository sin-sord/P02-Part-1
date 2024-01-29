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
        // this calls on the Rigidbody2D on Unity so that the obstacle can have the rigidbody be the reason for collision
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // this is what makes the obstacle rotate and have for to be able to push the player
        transform.Rotate(0,0, -RotationSpeed * Time.deltaTime);
        rigidbody.AddForce(direction * resistance * Time.deltaTime);
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // this will send a message to make sure the player collides with the obstacle
        Debug.Log("player got slammed");
    }
}
