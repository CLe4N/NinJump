using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public string SceneName;
    public AudioSource YooOOOooSFX;

    public void LoadNextHasSound()
    {
        YooOOOooSFX.Play(); // play YooOOOooSFX
        Invoke("loadNextScene", 2.0f); // Invoke method "loadNextScene" for 2 sec
    }
    public void loadNextScene()
    {
            SceneManager.LoadScene(SceneName); // loaad scene "SceneName"
    }

    public void LoadThisScene()
    {
        SceneName = SceneManager.GetActiveScene().name; // "SceneName" = get activee scene name 
        SceneManager.LoadScene(SceneName); // lord scene "SceneName"
        Time.timeScale = 1; // timescale = 1
    }

    public void Exit()
    {
        Application.Quit(); // quit applocation
    }
}
