using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSFX : MonoBehaviour
{
    AudioSource SFX;

    private void Start()
    {
        SFX = GetComponent<AudioSource>(); // access AudioSource GetComponent
    }
    void PlaySFX()
    {
        SFX.Play(); // play SFX
    }
}
