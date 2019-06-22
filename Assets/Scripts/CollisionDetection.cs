using System;
using UnityEngine;

public abstract class CollisionDetection : MonoBehaviour
{
    public string[] tagsThatCollide;

    public event Action Collided = delegate { };

    protected void OnCollision(GameObject other)
    {
        foreach (string tag in tagsThatCollide)
            if (other.tag == tag)
            {
                Collided();

                return;
            }
    }
}
