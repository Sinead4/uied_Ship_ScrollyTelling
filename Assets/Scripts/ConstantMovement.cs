using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using ShipScrolly;
using UnityEngine;

public class ConstantMovement : MonoBehaviour
{
    public float speed;

    public void ConstantShipMovement(float distanceTraveled)
    {
        speed = distanceTraveled / 35 + 20 * distanceTraveled / 400;
        if (distanceTraveled > 650 && distanceTraveled < 1500)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }
}
