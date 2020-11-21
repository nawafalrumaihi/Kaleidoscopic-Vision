using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * Time.deltaTime * 24;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * Time.deltaTime * 24;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * Time.deltaTime * 24;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * Time.deltaTime * 24;
        }

        if (Input.GetKey("space"))
        {
            transform.position += Vector3.up * Time.deltaTime * 24;
        }
    }
}
