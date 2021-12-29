using UnityEngine;
using Cinemachine;


namespace ShipScrolly
{
    public class DollyCamPathFollower : MonoBehaviour
    {
        public float speed = 10f;
        public float distanceTraveled;
        public Transform LookAtPoint;
        
        public CinemachineVirtualCamera currentCamera;
        public static CinemachineTrackedDolly cinemachineCamera;

        public TextBoxHandling textBoxHandling;
        public SailHandling sailHandling;

        public ConstantMovement constantMovement;

        void FixedUpdate()
        {
            Debug.Log("distanceTraveled is: " + distanceTraveled);
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
        
            cinemachineCamera = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            currentCamera.m_LookAt = textBoxHandling.title.transform;

            if (cinemachineCamera.m_PathPosition > 150)
            {
                currentCamera.m_LookAt = LookAtPoint;
            }
            else
            {
                currentCamera.m_LookAt = textBoxHandling.title.transform;
            }


            textBoxHandling.titleHandling(distanceTraveled);
            textBoxHandling.textBoxes(distanceTraveled);
            sailHandling.handlineOutlineShader(distanceTraveled);

            constantMovement.constantShipMovement(distanceTraveled);

        }
    }
    
}