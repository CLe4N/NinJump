using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    AudioSource JumpSFX;
    private void Start()
    {
        JumpSFX = GameObject.Find("JumpSFX").GetComponent<AudioSource>(); // Access AudioSource Component in "JumpSFX"
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0) // if collided gameobject velocity is less or equal to 0
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f); // Add 1000 force to up direction 
            JumpSFX.Play(); // play "JumpSFX"
        }
    }
}
