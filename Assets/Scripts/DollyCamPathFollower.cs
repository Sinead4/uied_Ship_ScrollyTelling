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

        void FixedUpdate()
        {
           
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
        
            cinemachineCamera = vCam1.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            vCam1.m_LookAt = textBoxHandling.title.transform;

            if (cinemachineCamera.m_PathPosition > 150)
            {
                vCam1.m_LookAt = LookAtPoint;
            }
            else
            {
                vCam1.m_LookAt = textBoxHandling.title.transform;
            }

            if (cinemachineCamera.m_PathPosition>650)
            {
                vCam2.Priority = 11;
            }
            else if (cinemachineCamera.m_PathPosition < 650)
            {
                vCam2.Priority = 9;
            }
            
            textBoxHandling.titleHandling(distanceTraveled);
            textBoxHandling.textBoxes(distanceTraveled);
            sailHandling.handlineOutlineShader(distanceTraveled);

            constantMovement.constantShipMovement(distanceTraveled);

        }
    }
    
}