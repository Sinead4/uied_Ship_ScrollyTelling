﻿using System;
using UnityEngine;
using Cinemachine;
using UnityEngine.Serialization;


namespace ShipScrolly
{
    public class DollyCamPathFollower : MonoBehaviour
    {
        public GameObject colonialShip;
        public float speed = 10f;
        public float distanceTraveled;
        public Transform LookAtPoint;
        
        public CinemachineVirtualCamera vCam1;
        public CinemachineVirtualCamera vCam2;
        public CinemachineVirtualCamera vCam3;
        public static CinemachineTrackedDolly cinemachineCamera;

        public TextBoxHandling textBoxHandling;
        public SailHandling sailHandling;
        public ConstantMovement constantMovement;
        public MilesTextHandling milesTextHandling;

        private void Start()
        {
            vCam2.Priority = 9;
            vCam3.Priority = 8;
        }

        void FixedUpdate()
        {
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
            cinemachineCamera = vCam1.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            vCam1.m_LookAt = textBoxHandling.title.transform;
            
            Vector3 changeVCam3Position = new Vector3(-25, 10, 0);
            vCam3.transform.position = colonialShip.transform.position + changeVCam3Position;
            vCam3.transform.rotation = colonialShip.transform.rotation;

            //Change look at point--------------------------
            if (distanceTraveled > 150)
            {
                vCam1.m_LookAt = LookAtPoint;
            }
            else
            {
                vCam1.m_LookAt = textBoxHandling.title.transform;
            }

            //Change camera -----------------------------------
            if (distanceTraveled>650)
            {
                vCam2.Priority = 11;
            }
            // else if (distanceTraveled < 650)
            // {
            //     vCam2.Priority = 9;
            // }
            if (distanceTraveled > 1500)
            {
                vCam2.Priority = 9;
                vCam3.Priority = 12;
            }
            
            textBoxHandling.titleHandling(distanceTraveled);
            textBoxHandling.textBoxes(distanceTraveled);
            
            textBoxHandling.KnotenHandling(colonialShip.transform.position, distanceTraveled);
            
            sailHandling.handlineOutlineShader(distanceTraveled);
            constantMovement.ConstantShipMovement(distanceTraveled);
            
            milesTextHandling.MilesTextPositioning(colonialShip.transform.position, (int)distanceTraveled);
        }
    }
    
}