using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipScrolly;

public class TextBoxHandling : MonoBehaviour
{
    public GameObject firstTextBox;
    //private DollyCamPathFollower dcpf;
    public GameObject title { get; set; }

    public GameObject compass;

    public Camera MainCamera;

    public GameObject knotenTextBox;

    // Start is called before the first frame update
    void Start()
    {
        firstTextBox = GameObject.Find("FirstTextBox");
        firstTextBox.SetActive(false);

        //dcpf = new DollyCamPathFollower();
        title = GameObject.Find("TitleObject");
        title.SetActive(true);

        compass = GameObject.Find("Kompass");
        compass.SetActive(false);

        knotenTextBox = GameObject.Find("Knoten");
        knotenTextBox.SetActive(false);

    }

    public void titleHandling(float distance)
    {
        if (distance >= 230)
        {
            title.SetActive(false);
        }
    }

    public void textBoxes(float distance)
    {

        if (distance >= 230 && distance <= 350)
        {
            firstTextBox.SetActive(true);
            firstTextBox.transform.LookAt(MainCamera.transform);
            
        }
        else
        {
            firstTextBox.SetActive(false);
        }

        if(distance >= 390 && distance <= 490)
        {
            compass.SetActive(true);
        }
        else
        {
            compass.SetActive(false);
        }

    }
    
    public void KnotenHandling(Vector3 position, float distanceTraveled)
    {
        Vector3 changeZPosition = new Vector3(-65, 25, -20);
        knotenTextBox.transform.position = position+changeZPosition;
        if (distanceTraveled >= 650 && distanceTraveled <= 1500)
        {
            knotenTextBox.SetActive(true);
        }
        else
        {
            knotenTextBox.SetActive(false);
        }
    }
}
