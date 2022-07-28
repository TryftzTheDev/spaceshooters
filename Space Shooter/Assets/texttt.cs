using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texttt : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {



        StartCoroutine(waiter());
    }

    // Update is called once per frame
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        Object.Destroy(this.gameObject);
    }
}
