using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyPlayerX : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy")
        {
            SceneManager.LoadScene("gameoverforclicking");
            Destroy(gameObject);
        }
    }
}