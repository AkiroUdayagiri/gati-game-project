using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Mechanics : MonoBehaviour
{
    public float speed = 10.5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1;
        }

        movement.Normalize(); // Ensure consistent movement speed in all directions

        rb.velocity = movement * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle collision events here
    }
}