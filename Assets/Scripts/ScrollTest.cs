using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shipObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var yRot = shipObject.GetComponent<Transform>().position.y;
        var newYPlus = yRot + Input.mouseScrollDelta.y;
        var newYMinus = yRot - Input.mouseScrollDelta.y;
        Console.WriteLine("newYPlus: " + newYPlus);
        Console.WriteLine("newYMinus: " + newYMinus);
        
        if (Input.mouseScrollDelta.y == -1)
        {
            shipObject.transform.Rotate(new Vector3(0.0f, newYPlus, 0.0f));
        }

        if (Input.mouseScrollDelta.y == 1)
        {
            shipObject.transform.Rotate(new Vector3(0.0f, 20, 0.0f));
        }
    }
}
