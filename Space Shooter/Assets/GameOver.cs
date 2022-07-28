using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Goal")
        {
            Destroy(gameObject);

            gameOverUI.SetActive(true);
        }
    }
}