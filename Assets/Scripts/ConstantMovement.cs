using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using ShipScrolly;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed;

    private CinemachineTrackedDolly cinemachine = DollyCamPathFollower.cinemachineCamera;
    
    // Update is called once per frame
    void Update()
    {
        
            
        
        
    }

    public void moveForward(float distance)
    {
        if(distance > 760)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
