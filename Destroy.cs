using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Destroy : MonoBehaviour
{
    public GameObject player; // Create public gameobject variable "player"
    public GameObject PlatformPrefab; // Create public gameobject variable "PlatformPrefab"
    public GameObject SpringPrefab; // Create public gameobject variable "SpringPrefab"
    public GameObject BrokenPrefab; // Create public gameobject variable "BrokenPrefab"
    public Text scoreText; // Create public Text variable "scoreText"
    int randomStat; // Create int variable "randomStat"
    int scorePoint; // Create int variable "scorePoint"
    GameObject myPlat; // Create GameObject variable "myPlat"
    void Start()
    {
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision) // do when this gameobject trigger collider is overlap with other trigger collider
    {
        if (collision.tag == "Platform") // do if other trigger collider tag is "Platform"
        {
            randomStat = Random.Range(1, 7); // " randomStat" = random number between 1 to 7
            if (randomStat > 5) // do if number in "randomStat" is more than 5
            {
                myPlat = (GameObject)Instantiate(SpringPrefab, new Vector2(Random.Range(-8.0f, 8.0f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
                //create gameobject from SpringPrefab. x position between -8.0 to 8.0. y position = player y position + (14 + random number between 0.5 to 1). ratate = 0
            }
            else // do if not
            {
                if (Random.Range(1, 6) > 3) // if random number between 1 to 6 is more than 3
                {
                    myPlat = (GameObject)Instantiate(BrokenPrefab, new Vector2(Random.Range(-8.0f, 8.0f), player.transform.position.y + (14 + Random.Range(0.5f, 1.5f))), Quaternion.identity);
                    //create gameobject from BrokenPrefab. x position between -8.0 to 8.0. y position = player y position + (14 + random number between 0.5 to 1.5). ratate = 0
                }
                else
                {
                    myPlat = (GameObject)Instantiate(PlatformPrefab, new Vector2(Random.Range(-8.0f, 8.0f), player.transform.position.y + (14 + Random.Range(0.5f, 1.5f))), Quaternion.identity);
                    //create gameobject from PlatformPrefab. x position between -8.0 to 8.0. y position = player y position + (14 + random number between 0.5 to 1.5). ratate = 0
                }
            }
            Destroy(collision.gameObject); // destroy overlaped gameobject
            scorePoint += 1; // "scorePoint" + 1
            scoreText.text = scorePoint.ToString(); // text of "scoreText" = value in "scorePoint"
        }
    }
}
