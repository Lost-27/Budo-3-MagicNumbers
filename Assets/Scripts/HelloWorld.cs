using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("GetKey");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("GetKeyDown");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("GetKeyUp");
        }
    }
   
}
