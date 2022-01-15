using System;
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
        public ShipsWheelRotation shipsWheelRotation;
        public AudioHandler audioHandler;

        public GameObject sailOne;
        public GameObject sailTwo;

        private void Start()
        {
            //Set priorities for cameras-------------------
            vCam1.Priority = 13;
            vCam2.Priority = 9;
            vCam3.Priority = 8;
        }

        void FixedUpdate()
        {
            Debug.Log("Distance: " + distanceTraveled);
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
            cinemachineCamera = vCam1.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;

            //Change look at point--------------------------
            if (distanceTraveled > 150)
            {
                vCam1.m_LookAt = LookAtPoint;
            }

            //Change camera -----------------------------------
            if (distanceTraveled > 830)
            {
                vCam1.Priority = 1;
                vCam2.Priority = 11;
            }
            else if (distanceTraveled < 830)
            {
                vCam2.Priority = 9;
            }
            if (distanceTraveled > 1400)
            {
                sailOne.SetActive(false);
                sailTwo.SetActive(false);
                
            }

            if (distanceTraveled > 1400)
            {
                vCam2.Priority = 9;
                vCam3.Priority = 12;
            }

            
            textBoxHandling.titleHandling(distanceTraveled);
            textBoxHandling.textBoxes(distanceTraveled);
            textBoxHandling.sailsTextBoxes(distanceTraveled);
            textBoxHandling.KnotenHandling(colonialShip.transform.position, distanceTraveled);
            shipsWheelRotation.QuestionHandling(distanceTraveled);
            sailHandling.handlineOutlineShader(distanceTraveled);
            constantMovement.ConstantShipMovement(distanceTraveled);
            milesTextHandling.MilesTextPositioning(colonialShip.transform.position, (int)distanceTraveled);
        }

        private void Update()
        {
           audioHandler.handleWaves(distanceTraveled);
        }
    }
    
}