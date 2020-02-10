using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed =50;
    public float jumpForce= 5;
    private float moveInput =0;

    private bool facingRight= true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;   
    /// <summary>
    /// Add layers to platform layers to for what is ground 
    /// </summary>

    Rigidbody2D rb;

    private int extraJumps;
    public int extraJumpsValue = 1;  // enter 1 or more for double jump



    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isGrounded)
        {
            extraJumps = extraJumpsValue;
        }

        if (IsJumping() && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }
        else if (IsJumping() && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    private static bool IsJumping()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingRight== false && moveInput >0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput <0 )
        {
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }


}
