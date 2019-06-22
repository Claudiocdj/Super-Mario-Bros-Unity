using UnityEngine;

[RequireComponent( typeof( MarioInputs ) )]
public class MarioJump : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 5f;
    [SerializeField]
    private bool canJump;

    private MarioInputs inputs;

    private void Update()
    {
        if (inputs.JumpButton && canJump)
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log( other.gameObject.transform.localPosition.y + " || " + transform.position.y );
        if(other.gameObject.tag == "Ground" &&
            other.gameObject.transform.localPosition.y < transform.position.y)
            canJump = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
            canJump = false;
    }
}
