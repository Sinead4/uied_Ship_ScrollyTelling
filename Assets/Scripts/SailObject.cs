using UnityEngine;


public class SailObject : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject sailTextBox;
    int countClicks = 0;
    public GameObject sails;
    public Material NoOutline;
    public Material Outline;
     

    void Start()
    {
        sailTextBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        countClicks++;

        if (countClicks % 2 != 0)
        {
            Debug.Log("in OnMouseDown if clause");
            sailTextBox.SetActive(true);
            sailTextBox.transform.LookAt(MainCamera.transform);
            sails.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(NoOutline);
           
        }
        else
        {
            Debug.Log("in OnMouseDown else clause");
            sailTextBox.SetActive(false);

            sails.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(Outline);
        }

    }

}
