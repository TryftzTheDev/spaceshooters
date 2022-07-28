using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DestroyPlayerV3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy")
        {
            SceneManager.LoadScene("gameoverforsurivivalreal");
            Destroy(gameObject);
        }
    }
}