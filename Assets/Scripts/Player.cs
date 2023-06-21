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
        //float directionY = Input.GetAxisRaw("Vertical");
       
        //playerDirection = new Vector2(0, directionY).normalized;
        if (Input.GetKeyDown(KeyCode.W) &&isGrounded==true)
        {
            rb.AddForce(Vector2.up * jump);
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

        Debug.Log(score);
        
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


    void FixedUpdate()
    {
       rb.velocity = new Vector2(0, playerDirection.y * playerSpeed); 
    }
}
