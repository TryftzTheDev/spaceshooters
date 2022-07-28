using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerUp : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.up * speed;
    }
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
        if (col.tag == "enemy")
        {
            ScoreManager.score += 1;
            Destroy(gameObject);
        }
    }
}
