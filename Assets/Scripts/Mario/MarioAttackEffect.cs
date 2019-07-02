using UnityEngine;

public class MarioAttackEffect : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    public void AttackEffect()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        GetComponent<Rigidbody2D>().AddForce( Vector2.up * jumpForce );
    }
}
