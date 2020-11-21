using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject PlatformPrefab;
    public GameObject SpringPrefab;
    public GameObject BrokenPrefab;
    public Text scoreText;
    int randomStat;
    int scorePoint;
    GameObject myPlat;
    void Start()
    {
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            randomStat = Random.Range(1, 7);
            if (randomStat > 5)
            {
                myPlat = (GameObject)Instantiate(SpringPrefab, new Vector2(Random.Range(-8.0f, 8.0f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
            }
            else
            {
                if (Random.Range(1, 6) > 3)
                {
                    myPlat = (GameObject)Instantiate(BrokenPrefab, new Vector2(Random.Range(-8.0f, 8.0f), player.transform.position.y + (14 + Random.Range(0.5f, 1.5f))), Quaternion.identity);
                }
                else
                {
                    myPlat = (GameObject)Instantiate(PlatformPrefab, new Vector2(Random.Range(-8.0f, 8.0f), player.transform.position.y + (14 + Random.Range(0.5f, 1.5f))), Quaternion.identity);
                }
            }
            Destroy(collision.gameObject);
            scorePoint += 1;
            scoreText.text = scorePoint.ToString();
        }
        else
        {

        }
    }
}
