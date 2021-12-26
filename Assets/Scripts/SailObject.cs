using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SailObject : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject sailTextBox;
    int countClicks = 0;
    public SailHandling sailHandling;


    void Start()
    {
        sailTextBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        countClicks++;

        if(countClicks%2 != 0)
        {
            sailTextBox.SetActive(true);
            sailTextBox.transform.LookAt(MainCamera.transform);
            this.GetComponent<MeshRenderer>().material.shader = sailHandling.NoOutlineShader;
      
        }
        else
        {
            sailTextBox.SetActive(false);
            this.GetComponent<MeshRenderer>().material.shader = sailHandling.OutlineShader;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
