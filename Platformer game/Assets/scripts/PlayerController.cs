using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb; // create reference for the rigidbody becuase jump requires physics
    public float jumpForce;// the force that will be added to the vertical component of player's velocity
    public float speed;

    //ground check Variable 
    // tells that the player is one the "ground layer"
    // layer assign to the ground
    public LayerMask groundLayer;
    public Transform groundCheck;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.transform, .5f, groundLayer);
        Vector3 newPosition = transform.position;
        Vector3 newScale = transform.localScale;
        float currentScale = Mathf.Abs(transform.localScale.x);


        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= speed;
            // to make our character change the direction they face 
            // this is done by change to sign of the scale between -ive and +ive
            newScale.x = -currentScale;

        
                
        
        }
        if (Input.GetKey("d")|| Input.GetKey(KeyCode.RightArrow)) 
        {
            newPosition.x += speed;

            newScale.x = currentScale;
        
        
        
        }

        if (Input.GetKeyDown("w")|| Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
            // get keydown check for the inital key press
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            // the line above sets the velocity to a new vector2 variable with a the x velocity remaining as is and the y velocity is assign jumpforce


        }

        transform.position = newPosition;
        transform.localScale = newScale;








        
    }
}
