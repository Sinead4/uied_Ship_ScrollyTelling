using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailHandling : MonoBehaviour
{
    public GameObject sailFrontAndBack;
    public GameObject sailMiddleFront;
    public GameObject sailMiddleBack;
    public Shader OutlineShader;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void handlineOutlineShader(float distance)
    {
        if(distance > 510)
        {
            sailFrontAndBack.GetComponent<MeshRenderer>().material.shader = OutlineShader;
            sailMiddleFront.GetComponent<MeshRenderer>().material.shader = OutlineShader;
            sailMiddleBack.GetComponent<MeshRenderer>().material.shader = OutlineShader;


         }
    }

    private void sailClicked()
    {

    }
}
