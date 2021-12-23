using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using ShipScrolly;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed;

    private CinemachineTrackedDolly cinemachine = DollyCamPathFollower.cinemachineCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
        
    }
}
