using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI;
    public Transform player;
    public AudioSource BGM;
    public AudioSource GameOverSFX;
    Vector3 Pos;
    private void Start()
    {
        Pos = player.position;
    }
    void Update()
    {
        if(player.transform.position.y > Pos.y)
        {
            Pos = player.position;
            transform.position = new Vector3(Pos.x, Pos.y - 10, Pos.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            BGM.Stop();
            GameOverSFX.Play();
            GameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
