using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShipScrolly
{
    public class Ship: MonoBehaviour
    {
        
        public float x;
        public float y;
        public float z;

        public Ship(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
          
            transform.position = new Vector3(x, y, z);
        }
        
        public void MoveShipTowardsAPoint( float x, float y, float z, float speed)
        {
            Vector3 newPos = new Vector3(x, y, z);
            transform.position = Vector3.MoveTowards(transform.position, newPos, speed);
            
        }
        
    }
}