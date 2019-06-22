using UnityEngine;

public class DetectionOnTriggerEnter : CollisionDetection
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnCollision( collision.gameObject );
    }
}
