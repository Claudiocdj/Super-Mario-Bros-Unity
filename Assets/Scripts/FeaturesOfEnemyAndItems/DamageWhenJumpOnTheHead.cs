using System;
using UnityEngine;

public class DamageWhenJumpOnTheHead : DetectorToInstantiate
{
    public event Action DamageEnemy = delegate { };

    protected override void OnTrigger(GameObject other)
    {
        Vector2 otherPos = other.transform.position;

        Vector2 myPos = transform.position;
        
        if (Mathf.Abs( otherPos.x - myPos.x ) < 0.8f && otherPos.y > myPos.y)
        {
            other.gameObject.GetComponent<MarioAttackEffect>().AttackEffect();

            if(GetComponent<ScoreGiven>())
                GetComponent<ScoreGiven>().SetScore();

            DamageEnemy();
        }
        else
        {
            MarioInvensibleEffect marioInvensibleEffect = other.gameObject.
                GetComponent<MarioInvensibleEffect>();

            if(marioInvensibleEffect && !marioInvensibleEffect.IsInvensible)
                other.gameObject.GetComponent<MarioDamage>().Damage();
        }
    }
}
