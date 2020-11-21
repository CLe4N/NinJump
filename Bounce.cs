using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    AudioSource JumpSFX; // create audiosource variable name JumpSFX
    private void Start()
    {
        JumpSFX = GameObject.Find("JumpSFX").GetComponent<AudioSource>(); // JumpSFX = Audiosource componet in gameobject "JumpSFX"
    }
    private void OnCollisionEnter2D(Collision2D collision) // gameobject collide with other collider
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0) // do if velocity of collided object is <=0
        {
            JumpSFX.Play(); // play "JumpSFX"
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f); // Add force to collided object = 600f in up direction
        }
    }
}
