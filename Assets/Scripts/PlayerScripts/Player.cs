using Assets.Scripts;
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
    private CharacterState currentState;

    private IInputAdapter _inputAdapter;

    //
    public float jumpSpeed = 3f;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
        //set idle state
        ChangeState(new IdleState(this));

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        MyscoreText.text = "Score: " + score.ToString();
        maxY = rb.transform.position.y + 3.5f;

        _inputAdapter = new KeyboardInputAdapter();
    }

    // Update is called once per frame
    void Update()
    {
        MyscoreText.text = "Score: " + score.ToString();
        //if (rb.position.y >= maxY)
        //{
        //    rb.velocity = new Vector2(rb.velocity.x, -jumpSpeed);
        //}



        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    float jumpInput = _inputAdapter.GetJumpInput();
        //    if(jumpInput > 0)
        //    {
        //        ChangeState(new JumpState());
        //    }
        //}

        currentState.Update();
    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        
            if (other.gameObject.CompareTag("Ground"))
            {
                isGrounded = false;
            }      
    }

    public void HandlePauseClick()
    {
        MenuManager.GoToMenu(MenuName.Pause);
    }

    public void ChangeState(CharacterState newState)
    {      
        currentState = newState;
        currentState.EnterState(this);
    }
    public void Jump()
    {
        if (isGrounded)
        {
            float jumpInput = _inputAdapter.GetJumpInput();

            if (jumpInput > 0)
            {
                animator.Play("Player_Jump");
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
            }      
        }
       

    }
    public void Idle()
    {      
        Debug.Log("Idle");
    }

    
    public void checkJump()
    {
        if (rb.position.y >= maxY)
        {
            rb.velocity = new Vector2(rb.velocity.x, -jumpSpeed);
            currentState.ExitState();

        }      
    }

}
