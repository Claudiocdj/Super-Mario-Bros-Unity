using System;
using UnityEngine;

public class CollideWithMario : DetectorToInstantiate
{
    public event Action<GameObject> BricksEffect = delegate { };

    protected override void OnTrigger(GameObject other)
    {
        Vector2 otherPos = other.transform.position;

        Vector2 myPos = transform.position;

        if (Mathf.Abs( otherPos.x - myPos.x ) < 0.8f && otherPos.y < myPos.y)
        {
            BricksEffect( other.gameObject );
        }
    }
}
