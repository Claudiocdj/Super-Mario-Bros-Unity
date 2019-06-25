using UnityEngine;

//depende de um objeto com rigidbody2D
public class JumpInputs : DetectorComponent
{
    [SerializeField]
    protected bool canJump;
    [SerializeField]
    protected float jumpForce;

    protected override void OnTrigger()
    {
        canJump = true;
    }

    protected void Jump()
    {
        if (canJump)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

            GetComponent<Rigidbody2D>().AddForce( Vector2.up * jumpForce );

            canJump = false;
        }
            
    }
}
