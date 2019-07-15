using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementByRigidBody : MonoBehaviour
{

    public float speed = 5f;
    [SerializeField]
    private float forceMult = 1f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rb.velocity.x > speed)
            rb.velocity = new Vector2(speed, rb.velocity.y );

        else if (rb.velocity.x < -speed)
            rb.velocity = new Vector2( -speed, rb.velocity.y );
    }

    protected void Move(Vector2 direction)
    {
        rb.AddForce( direction * speed * forceMult);
    }
}
