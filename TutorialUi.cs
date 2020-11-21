using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUi : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Destroy(this.gameObject);
            Time.timeScale = 1;
        }
    }
}
