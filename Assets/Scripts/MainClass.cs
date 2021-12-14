using System;
using System.Collections;
using System.Collections.Generic;
using ShipScrolly;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    // Start is called before the first frame update
    // public Ship newShip;
    private Vector3 startTitlePos;
    public GameObject title;
    public GameObject shipObj;

    void Start()
    {

        startTitlePos = title.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y == -1)
        {
            Vector3 newPosText = new Vector3(769, startTitlePos.y, startTitlePos.z);
            title.transform.position = Vector3.MoveTowards(title.transform.position, newPosText, 1.8f);
            
            Vector3 newPos = new Vector3(14, shipObj.transform.position.y, shipObj.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, newPos, 1.4f);

            if (startTitlePos.x >= 769)
            {
                title.SetActive(false); //Funktioniert nicht ???
            }
        }
        
       
        
            
         }
  
    }


