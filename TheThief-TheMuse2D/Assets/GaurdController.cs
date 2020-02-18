using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaurdController : MonoBehaviour
{
    public Vector2 Player1Restart;
    public Vector2 Player2Restart;

    public float speed = 10;
    public float jumpForce = 5;
    private float moveInput = -1;

    private bool facingRight = true;

    private bool isPlayerInGuardView;
    public Transform GuardView;
    public float GuardViewRadius = 10f;
    public LayerMask WhatIsPlayerLayer;

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
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        isPlayerInGuardView = Physics2D.OverlapCircle(GuardView.position, GuardViewRadius, WhatIsPlayerLayer);
        if(isPlayerInGuardView)
        {
            PlayerInGaurdView();
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        isWallChecked = Physics2D.OverlapCircle(wallCheck.position, checkRadius, whatIsGround);
        if (!isGrounded || isWallChecked)
        {
            Flip();
            moveInput *= -1;
        }

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


    }

    private void PlayerInGaurdView()
    {
        Debug.Log("Caughtttttttttttttttttttttt Start over");
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        allPlayers[0].transform.position = new Vector3(Player1Restart.x, Player1Restart.y);
        allPlayers[1].transform.position = new Vector3(Player2Restart.x, Player2Restart.y);

    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }

    private void OnDrawGizmos()
    {
//        Gizmos.DrawSphere(GuardView.position, GuardViewRadius);

        Gizmos.DrawWireSphere(GuardView.position, GuardViewRadius);

    }


}
