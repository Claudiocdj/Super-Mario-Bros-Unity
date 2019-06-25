using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnDamage : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<DamageWhenJumpOnTheHead>().DamageEnemy += DestroyEnemy;
    }

    private void DestroyEnemy()
    {
        Destroy( gameObject );
    }
}
