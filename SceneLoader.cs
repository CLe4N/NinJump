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
        YooOOOooSFX.Play();
        Invoke("loadNextScene", 2.0f);
    }
    public void loadNextScene()
    {
            SceneManager.LoadScene(SceneName);
    }

    public void LoadThisScene()
    {
        SceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
