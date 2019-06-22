using System;
using UnityEngine;

public class CliffDetection : CollisionDetection
{
    public event Action Collided = delegate { };

    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (string tag in tagsThatCollide)
            if(collision.gameObject.tag == tag)
            {
                Collided();

                return;
            }
    }
}
