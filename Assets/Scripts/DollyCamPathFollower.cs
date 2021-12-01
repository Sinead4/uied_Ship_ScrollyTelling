using UnityEngine;
using Cinemachine;
namespace DefaultNamespace
{
    public class DollyCamPathFollower : MonoBehaviour
    {
        public float speed = 2f;
        private float distanceTraveled;
    
        public CinemachineVirtualCamera currentCamera;
        public CinemachineTrackedDolly cinemachineTrackedDolly;
    
        
        void FixedUpdate()
        {
            distanceTraveled += speed * Input.mouseScrollDelta.y;
        
            cinemachineTrackedDolly = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineTrackedDolly.m_PathPosition = distanceTraveled;
        }
    }
    
}