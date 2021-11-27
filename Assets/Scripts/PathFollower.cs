using System;
using UnityEngine;
using System.Collections;

public class PathFollower : MonoBehaviour
{

    private float speed = 50f;
    public Transform pathParent;
    Transform targetPoint;
    int index;
    public GameObject objLookingat;
    public Camera camera;

    void OnDrawGizmos()
    {
        Vector3 from;
        Vector3 to;
        for (int a=0; a<pathParent.childCount; a++)
        {
            from = pathParent.GetChild(a).position;
            to = pathParent.GetChild((a+1) % pathParent.childCount).position;
            Gizmos.color = new Color (1, 0, 0);
            Gizmos.DrawLine (from, to);
        }
    }
    void Start () {
        index = 0;
        targetPoint = pathParent.GetChild (index);
    }
	
    // Update is called once per frame
    void Update () {

        if (objLookingat.transform.position.x == 14 && Input.mouseScrollDelta.y == -1)
        {
            Debug.Log("Camera Pos.: " + camera.transform.position);
            transform.position = Vector3.MoveTowards (transform.position, targetPoint.position, speed * Time.deltaTime);
                    transform.LookAt(objLookingat.transform);
                    if (Vector3.Distance (transform.position, targetPoint.position) < 0.1f) 
                    {
                        index++;
                        index %= pathParent.childCount;
                        targetPoint = pathParent.GetChild (index);
            
                    }
        }
        
       
    }
}