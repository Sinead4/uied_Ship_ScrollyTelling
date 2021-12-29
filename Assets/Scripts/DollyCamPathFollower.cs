using UnityEngine;
using Cinemachine;
using UnityEngine.Serialization;


namespace ShipScrolly
{
    public class DollyCamPathFollower : MonoBehaviour
    {
        public float speed = 10f;
        public float distanceTraveled;
        public Transform LookAtPoint;
        
        public CinemachineVirtualCamera vCam1;
        public CinemachineVirtualCamera vCam2;
        public static CinemachineTrackedDolly cinemachineCamera;

        public TextBoxHandling textBoxHandling;
        public SailHandling sailHandling;
        public ConstantMovement constantMovement;
        public MilesTextHandling milesTextHandling;

        void FixedUpdate()
        {
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
            cinemachineCamera = vCam1.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            vCam1.m_LookAt = textBoxHandling.title.transform;

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
            else if (distanceTraveled < 650)
            {
                vCam2.Priority = 9;
            }
            if (distanceTraveled > 1500)
            {
                vCam2.Priority = 9;
            }
            
            textBoxHandling.titleHandling(distanceTraveled);
            textBoxHandling.textBoxes(distanceTraveled);
            sailHandling.handlineOutlineShader(distanceTraveled);
            constantMovement.ConstantShipMovement(distanceTraveled);
            
            milesTextHandling.MilesTextPositioning(LookAtPoint.transform.position, (int)distanceTraveled);
        }
    }
    
}