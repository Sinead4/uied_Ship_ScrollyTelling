using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shipObject;
    private Vector3 currentShipPos;
    private Vector3 currentTitlePos;
    public GameObject title;
   
    void Start()
    {
        currentShipPos = shipObject.transform.position;
        currentTitlePos = title.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.mouseScrollDelta.y == -1)
        {
            Vector3 newPosShip = new Vector3(14, currentShipPos.y, currentShipPos.z);
            shipObject.transform.position = Vector3.MoveTowards(shipObject.transform.position, newPosShip, 1.5f);
            
            Vector3 newPosText = new Vector3(769, currentTitlePos.y, currentTitlePos.z);
            title.transform.position = Vector3.MoveTowards(title.transform.position, newPosText, 1.8f);

        }
  
    }
}
