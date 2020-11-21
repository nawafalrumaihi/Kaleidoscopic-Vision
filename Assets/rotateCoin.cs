using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCoin : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    int rotSpeed = 200;
    void Update()
    {
        
        transform.Rotate(0, rotSpeed * Time.deltaTime, 0, Space.World);
    }
}
