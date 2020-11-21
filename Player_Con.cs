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
        rb = GetComponent<Rigidbody2D>(); //access Rigidbody2D,SpriteRenderer,Animator of this gameobject
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement();
    }

    void movement()
    {
        moveInput = Input.GetAxis("Horizontal"); // "moveInput" = axis input "Horizontal"
        if (moveInput != 0 || moveInput == 0) // check "moveInput" value
        {
            if (moveInput < 0) // if value less than 0
            {
                sp.flipX = true; // flip this gameobject sprite on x axis
                anim.SetBool("Walk", true); // play walk animation
            }
            if (moveInput > 0) //if value more than 0
            {
                sp.flipX = false; // cancel flip
                anim.SetBool("Walk", true); //  play walk animation
            }
            if (moveInput == 0) // if value is 0
            {
                anim.SetBool("Walk", false); //stop walk animation
            }
        }
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y); // velocity on x axis of this game object = "moveInput" value * "speed"
    }
}
