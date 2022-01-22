using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;


    // Update is called once per frame --> good for player input mgmt
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horz", movement.x);
        animator.SetFloat("vert", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }
    // FixedUpdate is called 50 times/sec, regardless of frame rate --> good for character physics
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


    }
}
