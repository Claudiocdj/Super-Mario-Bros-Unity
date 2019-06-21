using System;
using UnityEngine;

public class CliffDetection : CollisionDetection
{
    public event Action CliffDetected = delegate { };
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach(string tag in tagsThatCollide)
            if(collision.gameObject.tag == tag)
            {
                FlipCollider();

                CliffDetected();
            }
    }

    protected override void FlipCollider()
    {
        Vector2 offset = transform.GetComponent<BoxCollider2D>().offset;

        transform.GetComponent<BoxCollider2D>().offset =
            new Vector2( offset.x * -1f, offset.y );
    }
}
