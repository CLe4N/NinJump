using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken: MonoBehaviour
{
    SpriteRenderer sp; // create SpriteRenderer variable name "sp"
    BoxCollider2D collide; // create BoxCollider2D variable name "collide"
    AudioSource JumpSFX; // create AudioSource variable name "JumpSFX"
    private void Start() // do on first frame
    {
        sp = GetComponent<SpriteRenderer>(); // "sp" = SpriteRenderer component of this gameobject
        collide = GetComponent<BoxCollider2D>(); // "collide" = BoxCollider2D component of this gameobject
        JumpSFX = GameObject.Find("JumpSFX").GetComponent<AudioSource>(); // "JumpSFX" = AudioSource component of "JumpSFX" gameobject
    }
    private void OnCollisionEnter2D(Collision2D collision) // do on collide with other collider
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0) // do if velocity in y axis of the collided gameobject <= 0
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 700f); // Addforce in up direction to collided gameobject = 700
            sp.enabled = false; // enabled "sp"
            collide.isTrigger = true; // turn collider of this gameobject to trigger
        }
    }
}
