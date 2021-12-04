using UnityEngine;
using Cinemachine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class DollyCamPathFollower : MonoBehaviour
    {
        public float speed = 10f;
        private float distanceTraveled;
        public Transform LookAtPoint;
        public Transform ship;
    
        public CinemachineVirtualCamera currentCamera;
        private CinemachineTrackedDolly cinemachineCamera;
    
        
        void FixedUpdate()
        {
            
            Debug.Log(distanceTraveled);
            distanceTraveled += speed * Input.mouseScrollDelta.y;
        
            cinemachineCamera = currentCamera.GetCinemachineComponent<CinemachineTrackedDolly> ();
            cinemachineCamera.m_PathPosition = distanceTraveled;
            currentCamera.m_LookAt = null;
            currentCamera.transform.rotation = Quaternion.Euler(8,3,0);
            
            if (cinemachineCamera.m_PathPosition > 150)
            {
                currentCamera.m_LookAt = LookAtPoint;
                //currentCamera.transform.rotation = Quaternion.Euler(0,-90,0);
                //transform.LookAt(ColonialShip);
            }

            // if (cinemachineCamera.m_PathPosition == 350)
            // {
            //     ship.transform.rotation = Quaternion.Euler(0,-90,0);
            // }
           
            
        }
    }
    
}