using System;
using UnityEngine;

public class WallDetection : CollisionDetection
{
    public event Action Collided = delegate { };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string tag in tagsThatCollide)
            if (collision.gameObject.tag == tag)
            {
                Collided();

                return;
            }
    }
}
