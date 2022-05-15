using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float PlayerSpeed;
    public float jumpSpeed;

    private bool isJumping;
    private float move;
    private Rigidbody2D rb;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * PlayerSpeed, rb.velocity.y);



        if(Input.GetButtonDown("Jump")&& !isJumping){
            rb.AddForce(new Vector2(rb.velocity.x , jumpSpeed));
            isJumping = true; 
            GetComponent<AudioSource>().Play();
        }

        RunAnimation();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("ground")){
            isJumping = false;
        }
    }

    void RunAnimation(){
        anim.SetFloat("Movement",Mathf.Abs(move));
        anim.SetBool("isJumping",isJumping);
    }

    private void FixedUpdate()
    {
        if (rb.position.y < -8f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(move<0){
            transform.eulerAngles = new Vector3(0, 180 , 0);
        }
        else if(move > 0){
            transform.eulerAngles = new Vector3(0,0,0);
        }
    }
}
