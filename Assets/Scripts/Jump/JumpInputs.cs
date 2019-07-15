using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JumpInputs : DetectorToInstantiate
{
    [SerializeField]
    protected bool canJump;
    [SerializeField]
    protected float jumpForce;

    private Rigidbody2D rb;

    protected override void Awake()
    {
        base.Awake();

        rb = GetComponent<Rigidbody2D>();
    }

    protected override void OnTrigger(GameObject other)
    {
        canJump = true;
    }

    protected void Jump()
    {
        if (canJump)
        {
            rb.velocity = new Vector2( rb.velocity.x, 0f );

            rb.AddForce( Vector2.up * jumpForce );

            canJump = false;
        }
            
    }
}
