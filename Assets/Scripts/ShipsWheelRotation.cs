using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipsWheelRotation : MonoBehaviour
{
    private float rotationSpeed = 4f;
    public GameObject ship;
    public GameObject shipsWheelCanvas;
    
    public TextMesh text;

    Vector3 changePosition = new Vector3(0, 5, -7);

    private void OnMouseDrag()
    {
        transform.Rotate((Vector3.forward*Input.GetAxis("Mouse X")*rotationSpeed)*(-1), Space.Self);
        ship.transform.Rotate((Vector3.up*Input.GetAxis("Mouse X")*rotationSpeed), Space.World);
        
        shipsWheelCanvas.transform.rotation = ship.transform.rotation;
        
        QuestionAnswerHandling();
       
    }
    public void QuestionHandling(float distanceTraveled)
    {
        shipsWheelCanvas.transform.position = ship.transform.position + changePosition;
        
        if (distanceTraveled > 1700)
        {
            shipsWheelCanvas.SetActive(true);
        }
        else
        {
            shipsWheelCanvas.SetActive(false);
        }
    }

    public void QuestionAnswerHandling()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            text.text = "Bravo";
        }
        else if (Input.GetAxis("Mouse X") > 0)
        {
            text.text = "Das war leider falsch";
        }
    }
}
