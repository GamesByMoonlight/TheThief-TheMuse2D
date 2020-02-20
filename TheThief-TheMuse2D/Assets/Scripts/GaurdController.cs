using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaurdController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 5;
    private float moveInput = -1;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;

    private bool isWallChecked;
    public Transform wallCheck;
    public float checkRadius= 0.5f;
    public LayerMask whatIsGround;
    /// <summary>
    /// Add layers to platform layers to for what is ground 
    /// </summary>

    public Rigidbody2D rb;
    // Start is called before the first frame update
    public GuardActions guardActions;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        guardActions = GetComponent<GuardActions>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        isWallChecked = Physics2D.OverlapCircle(wallCheck.position, checkRadius, whatIsGround);
        if (!isGrounded || isWallChecked)
        {
            Flip();
            moveInput *= -1;
        }
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    //private void IsPlayerInGaurdView()
    //{
    //    guardActions.IsPlayerInGaurdView(GuardView.position, GuardViewRadius, WhatIsPlayerLayer);
    //}

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }



}
