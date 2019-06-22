using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public bool movesToTheLeft = true;

    [SerializeField]
    private float speed = 1f;

    private void Awake()
    {
        if (!movesToTheLeft) FlipSprite();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 direction = movesToTheLeft ? Vector3.left : Vector3.right;

        transform.position += direction * speed * Time.deltaTime;
    }

    public void FlipSprite()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
    }
}
