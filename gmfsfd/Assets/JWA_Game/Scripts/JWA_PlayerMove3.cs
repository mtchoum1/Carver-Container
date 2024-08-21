using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//credits: Eno-Khaon (answers.unity.com)
// jjcrawley (answers.unity.com)
//DR: 35, JH: 5, Speed: 1
//Mass: 2, LD: 6, GS: 5
public class JWA_PlayerMove3 : MonoBehaviour {
    public Rigidbody2D Player;
    Rigidbody2D rb;
    [SerializeField] float jumpHeight;
    [SerializeField] float speed;
    [SerializeField] float decayRate;
    float jumpForce;
    Vector2 force;
    bool isGrounded;
    bool isJumping;
    bool jumpKeyHeld;
    bool canDoubleJump;
    public static float CalculateJumpForce(float gravityStrength, float jumpHeight)
    {
        return Mathf.Sqrt(2 * gravityStrength * jumpHeight);
    }
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpForce = CalculateJumpForce(Physics2D.gravity.magnitude, jumpHeight);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(0,0);
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpKeyHeld = true;
            if(isGrounded == true)
            {
                isJumping = true;
                canDoubleJump = true;
                isGrounded = false;
                //rb.velocity.y = 0;
                rb.AddForce(Vector2.up * jumpForce * rb.mass, ForceMode2D.Impulse);
                //print("up");
            } else if(canDoubleJump == true)
            {
                isJumping = true;
                print("working");
                canDoubleJump = false;
                //rb.velocity.y = 0;
                rb.AddForce(Vector2.up * jumpForce * rb.mass, ForceMode2D.Impulse);
            }

        }
        else if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            jumpKeyHeld = false;
        }
        //check mass, linear drag and gravity scale
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-Vector2.right*speed * Time.deltaTime, ForceMode2D.Impulse);
            //rb.velocity = new Vector2(-4,0);
            //print("left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right*speed * Time.deltaTime, ForceMode2D.Impulse);
            //rb.velocity = new Vector2(4,0);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
        isJumping = false;
    }
    void FixedUpdate()
    {
        if(isJumping == true)
        {
            float currentForce = jumpForce;
            if(jumpKeyHeld == true && Vector2.Dot(rb.velocity, Vector2.up) > 0)
            {
                while(Input.GetKey(KeyCode.UpArrow) && currentForce > 0)
                {
                    rb.AddForce(Vector2.up * currentForce);
                    currentForce -= decayRate * Time.deltaTime;
                }
                
            }
    }   }
}