using System;
using UnityEngine;

public class WallDetection : CollisionDetection
{
    public event Action CollidedWithWall = delegate { };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            FlipCollider();

            CollidedWithWall();
        }
    }

    protected override void FlipCollider()
    {
        transform.GetComponent<BoxCollider2D>().offset *= -1f;
    }
}
