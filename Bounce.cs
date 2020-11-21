using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    AudioSource JumpSFX;
    private void Start()
    {
        JumpSFX = GameObject.Find("JumpSFX").GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            JumpSFX.Play();
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
        }
    }
}
