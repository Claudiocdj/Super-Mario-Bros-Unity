using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallDie : MonoBehaviour
{
    [SerializeField]
    private GameObject fireBallEffect;

    public void DestroyFireBall()
    {
        Instantiate( fireBallEffect, transform.position, Quaternion.identity );

        Destroy( gameObject );
    }
}
