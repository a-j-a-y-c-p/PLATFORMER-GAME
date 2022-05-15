using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_scroller : MonoBehaviour
{

    public BoxCollider2D col;
    public Rigidbody2D rb;
    
    
    private float width; 

    private float scrollSpeed = -2f;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width= col.size.x;
        col.enabled = false;
        
        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width){
            Vector2 resetPosition = new Vector2(width*2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
