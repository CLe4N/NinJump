using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverUI; // create public gameobject variable "GameOverUI"
    public Transform player; // create public Transform variable "player"
    public AudioSource BGM; // create public AudioSource variable "BGM"
    public AudioSource GameOverSFX; // create public AudioSource variable "GameOverSFX"
    Vector3 Pos; // create Vector3 variable "Pos"
    
    private void Start() // do on first frame
    {
        Pos = player.position; // "Pos" = position of player
    }
    void Update() // do every frame
    {
        if(player.transform.position.y > Pos.y) // do if y position of player more than y value of "Pos"
        {
            Pos = player.position; // "Pos" = position of player
            transform.position = new Vector3(Pos.x, Pos.y - 10, Pos.z); // position of this gameobject = new vector3(Pos.x, Pos.y - 10, Pos.z)
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) // do if this gameobject Trigger collider is overlaped with other trigger collider
    {
        if(collision.tag == "Player") // overlaped collider has "Player" tag
        {
            BGM.Stop(); // stop "BGM" sound
            GameOverSFX.Play(); // Play "GameOverSFX" soumd
            GameOverUI.SetActive(true); // active "GameOverUI"
            Time.timeScale = 0; // set TimeScale to 0
        }
    }
}
