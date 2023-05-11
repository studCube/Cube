using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementByBottons : MonoBehaviour
{
    PlayerControl controls;

    private float horizontal;
    private float speed = 8f;
    public float jumpingPower = 16f;
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck1;
    [SerializeField] private Transform groundCheck2;
    [SerializeField] private Transform groundCheck3;
    [SerializeField] private Transform groundCheck4;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] public AudioSource JumpSoundEffect;

    private void Awake()
    {
        controls = new PlayerControl();
        controls.Enable();
    }

    void Update()
    {
        horizontal = SimpleInput.GetAxis("Horizontal");

        controls.Land.Jump.performed += ctx => Jump();
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded2())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
        
        if (Input.GetButtonDown("Jump") && IsGrounded3())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded4())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
    }


    void Jump()
    {
        
        if (IsGrounded())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (IsGrounded2())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
        
        if (IsGrounded3())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (IsGrounded4())
        {
            JumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck1.position, 0.2f, groundLayer);
    }

    private bool IsGrounded2()
    {
        return Physics2D.OverlapCircle(groundCheck2.position, 0.2f, groundLayer);
    }

    private bool IsGrounded3()
    {
        return Physics2D.OverlapCircle(groundCheck3.position, 0.2f, groundLayer);
    }

    private bool IsGrounded4()
    {
        return Physics2D.OverlapCircle(groundCheck4.position, 0.2f, groundLayer);
    }
}
