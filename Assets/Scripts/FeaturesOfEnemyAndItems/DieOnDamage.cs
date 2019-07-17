using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnDamage : MonoBehaviour
{
    [SerializeField]
    private GameObject deadEnemyPrefab;

    private void Awake()
    {
        GetComponent<DamageWhenJumpOnTheHead>().DamageEnemy += DestroyEnemy;
    }

    private void DestroyEnemy()
    {
        Instantiate( deadEnemyPrefab, transform.position, Quaternion.identity );

        Destroy( gameObject );
    }
}
