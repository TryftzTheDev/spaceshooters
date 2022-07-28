using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {



        StartCoroutine(waiter());
    }

    // Update is called once per frame
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        Object.Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}