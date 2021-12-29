using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilesTextHandling : MonoBehaviour
{
    public Text currentSpeedText;
    private GameObject ship = GameObject.Find("Colonial Ship");
    

    public void MilesTextPositioning(Vector3 position, int distanceTraveled)
    {
        currentSpeedText.gameObject.SetActive(true);
        if (distanceTraveled < 650)
        {
            currentSpeedText.gameObject.SetActive(false);
        }
        float speed = distanceTraveled / 50 + 2 * distanceTraveled / 217;
        Vector3 changeZPosition = new Vector3(0, 60, -30);
        currentSpeedText.transform.position = position+changeZPosition;
        currentSpeedText.text = "Das Schiff fährt " + (int)(speed*1.852) + " Knoten  Das entspricht ca. "+ (int)speed + " km/h";
        
    }
}
