using System;
using UnityEngine;

public class DamageWhenJumpOnTheHead : DetectorToInstantiate
{
    public event Action DamageEnemy = delegate { };

    protected override void OnTrigger(GameObject other)
    {
        Vector2 otherPos = other.transform.position;

        Vector2 myPos = transform.position;
        
        if (Mathf.Abs( otherPos.x - myPos.x ) < 0.5f && otherPos.y > myPos.y)
        {
            DamageEnemy();
        }
        else
        {
            //other.GetComponent<MarioDamage>.DamageMario();
        }
    }
}
