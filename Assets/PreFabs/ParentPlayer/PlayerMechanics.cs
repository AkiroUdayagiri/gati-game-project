using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    public Animator animator;
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

        if (Input.GetKey("w"))
        {
            movement.y = 1;
            animator.SetBool("UpKeyPress", true);
            animator.SetBool("RightKeyPress", false);
            animator.SetBool("LeftKeyPress", false);
        }
        if (Input.GetKey("s"))
        {
            movement.y = -1;
            animator.SetBool("RightKeyPress", false);
            animator.SetBool("UpKeyPress", false);
            animator.SetBool("LeftKeyPress", false);
        }
        if (Input.GetKey("d"))
        {
            movement.x = 1;
            animator.SetBool("RightKeyPress", true);
            animator.SetBool("LeftKeyPress", false);
            animator.SetBool("UpKeyPress", false);
        }
        if (Input.GetKey("a"))
        {
            movement.x = -1;
            animator.SetBool("LeftKeyPress", true);
            animator.SetBool("RightKeyPress", false);
            animator.SetBool("UpKeyPress", false);
        }

        movement.Normalize(); // Ensure consistent movement speed in all directions

        rb.velocity = movement * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle collision events here
    }
}