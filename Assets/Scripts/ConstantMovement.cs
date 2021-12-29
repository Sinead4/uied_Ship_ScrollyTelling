using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using ShipScrolly;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed;

    public void constantShipMovement(float distanceTraveled)
    {
        if (distanceTraveled > 650)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
