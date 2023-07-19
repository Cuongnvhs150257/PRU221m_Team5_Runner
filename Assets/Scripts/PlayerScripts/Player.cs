using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text MyscoreText;
    private Animator animator;
    private Rigidbody2D rb;
    public int score;
    public bool isGrounded;


    //
    public float jumpSpeed = 3f;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        MyscoreText.text = "Score: " + score.ToString();
        maxY = rb.transform.position.y + 3.5f;

    }

    // Update is called once per frame
    void Update()
    {          
        MyscoreText.text = "Score: " + score.ToString();

        /*
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector2.up * jump);

            {
            //animation
            isJumping = !isJumping;
            if (isJumping)
            {
                animator.Play("Player_Jump");
            }
            else
                animator.Play("Player_Run");
            }
        }
        */


        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            rb.gravityScale = 0;
            animator.Play("Player_Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);        

        }


        if (rb.position.y >= maxY)
        {
            rb.velocity = new Vector2(rb.velocity.x, -jumpSpeed);        

        }



    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        
            if (other.gameObject.CompareTag("Ground"))
            {
                isGrounded = false;
            }      
    }


}
