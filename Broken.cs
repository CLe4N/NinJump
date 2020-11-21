using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken: MonoBehaviour
{
    SpriteRenderer sp;
    BoxCollider2D collide;
    AudioSource JumpSFX;
    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        collide = GetComponent<BoxCollider2D>();
        JumpSFX = GameObject.Find("JumpSFX").GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700f);
            sp.enabled = false;
            collide.isTrigger = true;
        }
    }
}
