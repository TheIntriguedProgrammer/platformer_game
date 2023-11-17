using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Animation variables 
    Animator anim;
    public bool moving = false;
    public bool jumping = false;




    // Movement Variables
    Rigidbody2D rb; // create reference for the rigidbody becuase jump requires physics
    public float jumpForce;// the force that will be added to the vertical component of player's velocity
    public float speed;

    //ground check Variable 
    // tells that the player is one the "ground layer"
    // layer assign to the ground
    public LayerMask groundLayer; // layer information
    public Transform groundCheck; // player position info
    public bool isGrounded;

    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, .5f, groundLayer);
        Vector3 newPosition = transform.position;
        Vector3 newScale = transform.localScale;
        float currentScale = Mathf.Abs(transform.localScale.x);


        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= speed;
            // to make our character change the direction they face 
            // this is done by change to sign of the scale between -ive and +ive
            newScale.x = -currentScale;

            // this line of code is to activate the walk animation
            moving = true;
        }
        
        if (Input.GetKey("d")|| Input.GetKey(KeyCode.RightArrow)) 
        {
            newPosition.x += speed;

            newScale.x = currentScale;

            //controlls walking animation
            moving = true;
        
        
        
        }
        if (Input.GetKeyUp("a") || Input.GetKeyUp("d") || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            moving = false;
        }
        if (isGrounded == true)
        {
            jumping = false;
        }


        if ((Input.GetKeyDown("w")|| Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded == true)
            // get keydown check for the inital key press
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            // the line above sets the velocity to a new vector2 variable with a the x velocity remaining as is and the y velocity is assign jumpforce

            jumping = true;
        }




        anim.SetBool("isMoving", moving);
        anim.SetBool("isJumping", jumping);  
        transform.position = newPosition;
        transform.localScale = newScale;








        
    }
}
