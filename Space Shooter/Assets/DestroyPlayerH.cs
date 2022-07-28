using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyPlayerH : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy")
        {
            SceneManager.LoadScene("GAMEOVERFORSURVIVAL");
            Destroy(gameObject);
        }
    }
}