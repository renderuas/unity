//test script for unity

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left"))
        {
            gameobject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("right"))
        {
            gameobject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
        
    }
}
