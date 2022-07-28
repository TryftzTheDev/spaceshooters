using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenue : MonoBehaviour
{
    [SerializeField] GameObject pauseMenue;

    public void Pause()
    {
        pauseMenue.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenue.SetActive(false);
        Time.timeScale = 1f;


    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
