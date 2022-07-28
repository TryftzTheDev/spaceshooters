using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionscript : MonoBehaviour
{
    public float moveSpeed = 0f;

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(1f, 0f) * moveSpeed * Time.deltaTime);
    }
}