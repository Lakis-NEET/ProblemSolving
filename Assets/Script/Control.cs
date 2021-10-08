using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;

        velocity.x = speed * Input.GetAxis("Horizontal");
        velocity.y = speed * Input.GetAxis("Vertical");
        /*
        if (Input.GetKey(up))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(down))
        {
            velocity.y = -speed;
        }
        if (Input.GetKey(right))
        {
            velocity.x = speed;
        }
        else if (Input.GetKey(left))
        {
            velocity.x = -speed;
        }*/

        rigidBody2D.velocity = velocity;
    }
}
