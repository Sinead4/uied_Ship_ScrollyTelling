using System;
using System.Collections;
using System.Collections.Generic;
using ShipScrolly;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    // Start is called before the first frame update
    // public Ship newShip;
    private Vector3 startShipPos;
    private Vector3 startTitlePos;
    public GameObject title;
    public GameObject shipObj;

    void Start()
    {
        // newShip = gameObject.AddComponent<Ship>();
            // new Ship(new Vector3(-165, 3.6f, 60));
        // startShipPos = this.transform.position;
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
        
       
        

        // if (Input.mouseScrollDelta.y == -1)
        // {
        //     Debug.Log("xPos: " + newShip.transform.position.x);
        //     Debug.Log("yPos: " + newShip.transform.position.y);
        //     Debug.Log("zPos: " + newShip.transform.position.z);
        //
        //     if (newShip.transform.position.x <= 14)
        //     {
        //         newShip.MoveShipTowardsAPoint(14, newShip.transform.position.y, newShip.transform.position.z, 1.5f);
        //        
        //         Vector3 newPosText = new Vector3(769, startTitlePos.y, startTitlePos.z);
        //         title.transform.position = Vector3.MoveTowards(title.transform.position, newPosText, 1.8f);
        //     }
        //
        //     if (newShip.transform.position.x == 14)
        //     {
        //         newShip.transform.Rotate(0,0,0);
        //     }
            
         }
  
    }


