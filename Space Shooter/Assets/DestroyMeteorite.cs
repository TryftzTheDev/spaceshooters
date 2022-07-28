using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeteorite : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.name == "Square(Clone)")
        {
            Destroy(this.gameObject);

        }
    }
}
