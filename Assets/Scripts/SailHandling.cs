using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailHandling : MonoBehaviour
{
    public GameObject sailFrontAndBack;
    public GameObject sailMiddleFront;
    public GameObject sailMiddleBack;
    public Shader OutlineShader;
    public Material sailFrontAndBackMaterial;
    public Material sailMiddleFrontMaterial;
    public Material sailMiddleBackMaterial;

    //Pulse 
    public float growthBound;
    public float shrinkBound;
    public float currentRatio;
    public float approachSpeed;
    private Coroutine routine;
    private bool isPulsing = false;


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
        if(distance > 510 && distance <= 700)
        {
            
            sailFrontAndBack.GetComponent<MeshRenderer>().material.shader = OutlineShader;
            sailMiddleFront.GetComponent<MeshRenderer>().material.shader = OutlineShader;
            sailMiddleBack.GetComponent<MeshRenderer>().material.shader = OutlineShader;
            if (!isPulsing)
            {
                this.routine = StartCoroutine(this.Pulse());
            }
            
        }
        else
        {
            sailFrontAndBack.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(sailFrontAndBackMaterial);
            sailMiddleFront.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(sailMiddleFrontMaterial);
            sailMiddleBack.GetComponent<Renderer>().material.CopyPropertiesFromMaterial(sailMiddleBackMaterial);
        }
    }

    private IEnumerator Pulse()
    {
        isPulsing = true;

        while (this.currentRatio != this.growthBound)
        {
            // Determine the new ratio to use
            currentRatio = Mathf.MoveTowards(currentRatio, growthBound, approachSpeed);

            // Update element
            sailFrontAndBack.transform.localScale = Vector3.one * currentRatio;
            sailMiddleFront.transform.localScale = Vector3.one * currentRatio;
            sailMiddleBack.transform.localScale = Vector3.one * currentRatio;

            yield return new WaitForSecondsRealtime(0.4f);
        }

        // Shrink for a few seconds
        while (this.currentRatio != this.shrinkBound)
        {
            // Determine the new ratio to use
            currentRatio = Mathf.MoveTowards(currentRatio, shrinkBound, approachSpeed);

            // Update element
            sailFrontAndBack.transform.localScale = Vector3.one * currentRatio;
            sailMiddleFront.transform.localScale = Vector3.one * currentRatio;
            sailMiddleBack.transform.localScale = Vector3.one * currentRatio;

            yield return new WaitForSecondsRealtime(0.4f);
        }

        if(currentRatio == shrinkBound)
        {
            isPulsing = false;
        }
    }
}

