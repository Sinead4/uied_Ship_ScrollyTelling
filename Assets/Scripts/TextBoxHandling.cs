using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShipScrolly;

public class TextBoxHandling : MonoBehaviour
{
    public GameObject firstTextBox;
    private DollyCamPathFollower dcpf;
    public GameObject title;

    public GameObject compass;

    // Start is called before the first frame update
    void Start()
    {
        firstTextBox = GameObject.Find("FirstTextBox");
        firstTextBox.SetActive(false);

        dcpf = new DollyCamPathFollower();
        title = GameObject.Find("Title");
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
            Debug.Log("In titleHandling");
            title.SetActive(false);
        }
    }

    public void textBoxes(float distance)
    {
        Debug.Log("In textBoxes");
        if (distance >= 230 && distance <= 350)
        {
            Debug.Log("In first TextBox distance= " + distance);
            firstTextBox.SetActive(true);
        }
        else
        {
            firstTextBox.SetActive(false);
        }

        if(distance >= 390)
        {
            Debug.Log("In Kopass Obj distance= " + distance);
            compass.SetActive(true);
        }

    }
}
