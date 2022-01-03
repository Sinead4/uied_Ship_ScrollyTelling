using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipsWheelRotation : MonoBehaviour
{
    private float speed = 5f;
    public GameObject ship;

    private void OnMouseDrag()
    {
        transform.Rotate((Vector3.forward*Input.GetAxis("Mouse X")*speed)*(-1), Space.Self);

        ship.transform.Rotate((Vector3.up*Input.GetAxis("Mouse X")*speed), Space.Self);
    }
}
