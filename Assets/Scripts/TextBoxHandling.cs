using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipScrolly;

public class TextBoxHandling : MonoBehaviour
{
    public GameObject firstTextBox;
    private DollyCamPathFollower dcpf;
    public GameObject title { get; set; }

    public GameObject compass;

    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        firstTextBox = GameObject.Find("FirstTextBox");
        firstTextBox.SetActive(false);

        dcpf = new DollyCamPathFollower();
        title = GameObject.Find("TitleObject");
        title.SetActive(true);

        compass = GameObject.Find("Kompass");
        compass.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

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
}