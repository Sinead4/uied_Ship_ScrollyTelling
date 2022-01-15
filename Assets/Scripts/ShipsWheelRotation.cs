using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipsWheelRotation : MonoBehaviour
{
    private float rotationSpeed = 4f;
    public GameObject ship;
    public GameObject exitButton;
    public Text text;
    public GameObject answerCanvas;
    public Texture2D dragCursor;

    private void Start()
    {
        exitButton.SetActive(false);
        answerCanvas.SetActive(false);
    }

    private void Update()
    {
        ChangeCursor(dragCursor);
    }

    private void OnMouseDrag()
    {
        transform.Rotate((Vector3.forward*Input.GetAxis("Mouse X")*rotationSpeed)*(-1), Space.Self);
        ship.transform.Rotate((Vector3.up*Input.GetAxis("Mouse X")*50*Time.deltaTime), Space.World);

        QuestionAnswerHandling();
       
    }
    public void QuestionHandling(float distanceTraveled)
    {
        if (distanceTraveled > 1400)
        {
            Cursor.visible = true;
            Cursor.SetCursor(dragCursor, Vector2.zero, CursorMode.Auto);
            answerCanvas.SetActive(true);
        }
        else
        {
            answerCanvas.SetActive(false);
        }
    }

    private void QuestionAnswerHandling()
    {
        if (Input.GetAxis("Mouse X") < -0.3)
        {   
            exitButton.SetActive(true);
            text.text = "Bravo!";
        }
        else if (Input.GetAxis("Mouse X") > 0.3)
        {
            text.text = "Das war leider falsch, versuchs nochmals";
        }
    }

    private void ChangeCursor(Texture2D cursor)
    {
        if (Input.mousePosition.y == transform.position.y && Input.mousePosition.z == transform.position.z)
        {
            Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        }
    }
}
