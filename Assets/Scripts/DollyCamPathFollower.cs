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
       // public GameObject title;
       // public GameObject firstTextBox;

        void FixedUpdate()
        {
            Debug.Log("distanceTraveled is: " + distanceTraveled);
            distanceTraveled += (speed * Input.mouseScrollDelta.y)*-1;
        
            cinemachineCamera = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            currentCamera.m_LookAt = null;

            if (cinemachineCamera.m_PathPosition > 150)
            {
                currentCamera.m_LookAt = LookAtPoint;
            }

            handling.titleHandling(distanceTraveled);
            handling.textBoxes(distanceTraveled);
           
        }
    }
    
}