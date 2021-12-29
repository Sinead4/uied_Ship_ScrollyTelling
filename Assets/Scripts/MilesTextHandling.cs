using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilesTextHandling : MonoBehaviour
{
    public Text currentSpeed;
    private GameObject ship = GameObject.Find("Colonial Ship");

    private int kmH = 0;

    private int knoten = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MilesTextPositioning(Vector3 position, int speed)
    {
        Vector3 changeZPosition = new Vector3(0, 0, -30);
        currentSpeed.transform.position = position+changeZPosition;
        currentSpeed.text = "Das Schiff fährt " + speed + " km/h.";
        
    }
}
