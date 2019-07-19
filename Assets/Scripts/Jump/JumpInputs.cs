using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JumpInputs : DetectorToInstantiate
{
    [SerializeField]
    protected bool canJump;

    [SerializeField]
    protected float jumpForce;

    private Rigidbody2D rb;

    public bool IsJumping { get; private set; }

    protected override void Awake()
    {
        base.Awake();

        rb = GetComponent<Rigidbody2D>();
    }

    protected override void OnTrigger(GameObject other)
    {
        canJump = true;

        IsJumping = false;
    }

    protected void Jump(GameObject obj)
    {
        if (canJump && rb.velocity.y == 0)
        {
            IsJumping = true;

            if(obj.tag == "Player")
                GameObject.FindWithTag("SoundClips")
                .GetComponent<SoundClips>().Jump();

            rb.velocity = new Vector2( rb.velocity.x, 0f );

            rb.AddForce( Vector2.up * jumpForce );

            canJump = false;
        }  
    }
}
