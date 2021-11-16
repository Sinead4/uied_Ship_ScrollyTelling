using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shipObject;
    private Vector3 currentShipPos;
   
    void Start()
    {
        currentShipPos = shipObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.mouseScrollDelta.y == -1)
        {
            Vector3 newPos = new Vector3(14, currentShipPos.y, currentShipPos.z);
            shipObject.transform.position = Vector3.MoveTowards(shipObject.transform.position, newPos, 1.5f);
   
        }
  
    }
}
