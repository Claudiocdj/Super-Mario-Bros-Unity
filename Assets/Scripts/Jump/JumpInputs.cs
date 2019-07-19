using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class JumpInputs : DetectorToInstantiate
{
    [SerializeField]
    protected bool canJump;

    [SerializeField]
    protected float jumpForce;

    [SerializeField]
    protected AudioClip audioJump;

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

    protected void Jump()
    {
        if (canJump && rb.velocity.y == 0)
        {
            IsJumping = true;

            if(audioJump != null)
                SetSound();

            rb.velocity = new Vector2( rb.velocity.x, 0f );

            rb.AddForce( Vector2.up * jumpForce );

            canJump = false;
        }  
    }

    private void SetSound()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.clip = audioJump;

        audio.Play();
    }
}
