using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text MyscoreText;
    private Animator animator;
    bool isJumping = false;
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public int score;
    public float jump;
    public bool isGrounded;


    //
    public float speed;
    public float topY;
    public float bottomY;
    private bool movingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        MyscoreText.text = "Score: " + score.ToString(); 
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
            Debug.Log("he");
            if (movingUp)
            {
                rb.transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, topY), speed * Time.deltaTime);
                if (rb.transform.position.y >= topY)
                {
                    movingUp = false;
                }
            }
            else
            {
                
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, bottomY), speed * Time.deltaTime);
                if (transform.position.y <= bottomY)
                {
                    movingUp = true;
                }
                
            }

            //animation
            isJumping = !isJumping; 
            if (isJumping)
            {
                animator.Play("Player_Jump");
            }
            else
            {
                animator.Play("Player_Run");
            }
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
