using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    bool isJumping = false;
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
       
        playerDirection = new Vector2(0, directionY).normalized;
        if (Input.GetKeyDown(KeyCode.W))
        {
            // ??i giá tr? c?a bi?n isJumping
            isJumping = !isJumping;

            // N?u isJumping là true thì chuy?n sang animator Jump
            if (isJumping)
            {
                animator.Play("Player_Jump");
            }
            // Ng??c l?i n?u isJumping là false thì chuy?n sang animator Run
            else
            {
                animator.Play("Player_Run");
            }
        }

        Debug.Log(score);
        
    }

    void FixedUpdate()
    {
       rb.velocity = new Vector2(0, playerDirection.y * playerSpeed); 
    }
}
