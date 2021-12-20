using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D collider;

    public Rigidbody2D rb;
    private float width;
    private float scrollSpeed = -100f;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 currentPosition = transform.position;
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        width = 400;
        // collider.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(scrollSpeed+speed, 0, 0);
        Vector3 currentPosition = transform.position;
        if (transform.position.x < -400)
        {
            Vector3 resetPosition = new Vector3(currentPosition.x + 1600, currentPosition.y, currentPosition.z);
            transform.position = resetPosition;
            //transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
