using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("HelloUnity");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StopCoroutine("HelloUnity");
        }
    }

    IEnumerator HelloUnity()
    {
        while(true)
        {
            yield return null;
            Debug.Log("Unity");
        }
    }
}
