using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioVerticalAnimator : MonoBehaviour
{
    private Animator an;
    private Rigidbody2D rb;
    private JumpInputs controller;

    private void Awake()
    {
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        controller = GetComponent<JumpInputs>();
    }

    private void Update()
    {
        VerticalMovement();
    }

    private void VerticalMovement()
    {
        if(Mathf.Abs(rb.velocity.y) > 0.1f)
        {
            if (controller.IsJumping)
                an.SetBool( "isJumping", true );

            else if(rb.velocity.y < 0)
                an.SetBool( "isFalling", true );
        }
        else
        {
            an.SetBool( "isJumping", false );
            an.SetBool( "isFalling", false );
        }
    }
}
