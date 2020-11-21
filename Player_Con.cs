using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Con : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;
    Animator anim;
    float moveInput;
    float speed = 10;
    public bool IsGround;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement();
    }

    void movement()
    {
        moveInput = Input.GetAxis("Horizontal");
        if (moveInput != 0 || moveInput == 0)
        {
            if (moveInput < 0)
            {
                sp.flipX = true;
                anim.SetBool("Walk", true);
            }
            if (moveInput > 0)
            {
                sp.flipX = false;
                anim.SetBool("Walk", true);
            }
            if (moveInput == 0)
            {
                anim.SetBool("Walk", false);
            }
        }
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
