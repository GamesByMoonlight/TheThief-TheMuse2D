using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaurdController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 5;
    private float moveInput = -1;

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
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


    }

}
