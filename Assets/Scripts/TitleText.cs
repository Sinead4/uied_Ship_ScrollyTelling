using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleText : MonoBehaviour
{
    private Text title;
    // Start is called before the first frame update
    void Start()
    {

        title = GetComponent<Text>();
        // title.text = "Die Brigantine";
        // title.fontStyle = FontStyle.Bold;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
