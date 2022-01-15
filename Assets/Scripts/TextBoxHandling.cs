using UnityEngine;


public class TextBoxHandling : MonoBehaviour
{
    public GameObject firstTextBox;
    public GameObject sailsTextBox1;
    public GameObject sailsTextBox2;
    public GameObject sailsInfoBox;
    public GameObject title;
    public GameObject compass;
    public Camera MainCamera;
    public GameObject knotenTextBox;
    public AudioSource wavesAudio;
    public Texture2D dragCursor;

    // Start is called before the first frame update
    void Start()
    {
        firstTextBox = GameObject.Find("Einleitungsbox");
        firstTextBox.SetActive(false);
        
        title = GameObject.Find("TitelObject");
        title.SetActive(true);

        compass = GameObject.Find("Kompass");
        compass.SetActive(false);

        knotenTextBox = GameObject.Find("Knoten");
        knotenTextBox.SetActive(false);

    }

    public void titleHandling(float distance)
    {
        if (distance >= 160)
        {
            title.SetActive(false);
        }
    }

    public void textBoxes(float distance)
    {
        if (distance >= 300 && distance <= 420)
        {
            firstTextBox.SetActive(true);
            firstTextBox.transform.LookAt(MainCamera.transform);
        }
        else
        {
            firstTextBox.SetActive(false);
        }

        if(distance >= 490 && distance <= 720)
        {
            compass.SetActive(true);
        }
        else
        {
            compass.SetActive(false);
        }
    }
    
    public void KnotenHandling(Vector3 position, float distanceTraveled)
    {
        Vector3 changeZPosition = new Vector3(-65, 25, -20);
        knotenTextBox.transform.position = position+changeZPosition;
        
        if (distanceTraveled >= 830 && distanceTraveled <= 1400)
        {
            wavesAudio.volume = 0f;
            knotenTextBox.SetActive(true);
        }
        else
        {
            knotenTextBox.SetActive(false);
        }
    }

    public void sailsTextBoxes(float distance)
    {
        if(distance > 640 && distance < 850)
        {
            sailsInfoBox.SetActive(true);
        }

        if (distance > 700 && distance < 830)
        {
            Cursor.visible = true;
            Cursor.SetCursor(dragCursor, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            Cursor.visible = false;
        }
       
        if (distance < 640 || distance >= 780)
        {
            sailsInfoBox.SetActive(false);
            sailsTextBox1.SetActive(false);
            sailsTextBox2.SetActive(false);
        }
    }
}
