using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }
    void Update()
    {

        walk();
    }
}
