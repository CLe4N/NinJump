using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUi : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0; // timescale is equal 0
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) // if down key button is pressed
        {
            Destroy(this.gameObject); // destroy this game object
            Time.timeScale = 1; // timescale is equal 1
        }
    }
}
