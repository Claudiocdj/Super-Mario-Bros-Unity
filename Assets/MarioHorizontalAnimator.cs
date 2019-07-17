using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioHorizontalAnimator : MonoBehaviour
{
    private Animator an;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private ControllerInputs controller;

    private bool facingRight = true;

    private void Awake()
    {
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        controller = GetComponent<ControllerInputs>();
    }

    private void Update()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement()
    {
        if( Mathf.Abs(rb.velocity.x) > 0.1)
        {
            an.SetBool( "isWalking", true );

            CheckSpriteFlip();

            CheckSlipping();
        }
        else
            an.SetBool( "isWalking", false );
    }

    private void CheckSpriteFlip()
    {
        if (( controller.InputRight && !facingRight ) ||
            ( controller.InputLeft && facingRight ))
        {
            sr.flipX = !sr.flipX;
            facingRight = !facingRight;
        }
    }

    private void CheckSlipping()
    {
        if((rb.velocity.x > 0 && controller.InputLeft) ||
            (rb.velocity.x < 0 && controller.InputRight))
            an.SetBool( "isSlipping", true );
        else
            an.SetBool( "isSlipping", false );
    }
}
