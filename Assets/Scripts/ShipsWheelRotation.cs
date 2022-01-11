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
    public GameObject endBox;
    
    public Text text;

    public GameObject answerCanvas;
    
    Vector3 changePosition = new Vector3(0, 5, -7);

    private void Start()
    {
        endBox.SetActive(false);
        answerCanvas.SetActive(false);
    }

    private void OnMouseDrag()
    {
        transform.Rotate((Vector3.forward*Input.GetAxis("Mouse X")*rotationSpeed)*(-1), Space.Self);
        ship.transform.Rotate((Vector3.up*Input.GetAxis("Mouse X")*rotationSpeed), Space.World);

        QuestionAnswerHandling();
       
    }
    public void QuestionHandling(float distanceTraveled)
    {
        if (distanceTraveled > 1710)
        {
            answerCanvas.SetActive(true);
        }
        else
        {
            answerCanvas.SetActive(false);
        }
    }

    public void QuestionAnswerHandling()
    {
        if (Input.GetAxis("Mouse X") < -0.1)
        {   
            endBox.SetActive(true);
            text.text = "Bravo!";
                        
        }
        else if (Input.GetAxis("Mouse X") > 0.1)
        {
            text.text = "Das war leider falsch, versuchs nochmals";
        }
    }
}
