using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed = 50.0f;
    private Vector2 trajectoryOrigin;
    private Rigidbody2D rigidBody2D;
    public float xInitial;
    public float yInitial;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.AddForce(new Vector2(xInitial, yInitial) * speed);
    }
}
