using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipScrolly;

public class TextBoxHandling : MonoBehaviour
{
    public GameObject firstTextBox;
    public GameObject sailsTextBox1;
    public GameObject sailsTextBox2;
    public GameObject title { get; set; }

    public GameObject compass;

    public Camera MainCamera;

    public GameObject knotenTextBox;

    public GameObject shipsWheelCanvas;

    public AudioSource wavesAudio;

    // Start is called before the first frame update
    void Start()
    {
        firstTextBox = GameObject.Find("Einleitungsbox");
        firstTextBox.SetActive(false);

        //dcpf = new DollyCamPathFollower();
        title = GameObject.Find("Titel");
        title.SetActive(true);

        compass = GameObject.Find("Kompass");
        compass.SetActive(false);

        knotenTextBox = GameObject.Find("Knoten");
        knotenTextBox.SetActive(false);

    }

    public void titleHandling(float distance)
    {
        if (distance >= 160)
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
        if (distanceTraveled >= 700 && distanceTraveled <= 1700)
        {
            wavesAudio.volume = 0f;
            knotenTextBox.SetActive(true);
        }
        else
        {
            knotenTextBox.SetActive(false);
        }
    }

    public void sailsTextBoxes(float distance)
    {
        if (distance < 510 || distance >= 640)
        {
            sailsTextBox1.SetActive(false);
            sailsTextBox2.SetActive(false);
        }
    }
}
