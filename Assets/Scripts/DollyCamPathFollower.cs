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
        
        public CinemachineVirtualCamera currentCamera;
        private CinemachineTrackedDolly cinemachineCamera;

        public TextBoxHandling handling;

        void FixedUpdate()
        {
            Debug.Log("distanceTraveled is: " + distanceTraveled);
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
        
            cinemachineCamera = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            currentCamera.m_LookAt = handling.title.transform;

            if (cinemachineCamera.m_PathPosition > 150)
            {
                currentCamera.m_LookAt = LookAtPoint;
            }
            else
            {
                currentCamera.m_LookAt = handling.title.transform;
            }


            handling.titleHandling(distanceTraveled);
            handling.textBoxes(distanceTraveled);
           
        }
    }
    
}