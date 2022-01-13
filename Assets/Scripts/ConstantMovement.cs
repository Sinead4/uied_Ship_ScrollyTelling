using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using ShipScrolly;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float shipSpeed;

    public void ConstantShipMovement(float distanceTraveled)
    {
        shipSpeed = distanceTraveled / 35 + 20 * distanceTraveled / 400;
        if (distanceTraveled > 830)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * shipSpeed);
        }
        
    }
}
