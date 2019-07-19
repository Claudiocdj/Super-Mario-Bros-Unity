using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiesAfterATime : MonoBehaviour
{
    [SerializeField]
    private float time;

    void Start()
    {
        StartCoroutine( DestroyFireBall() );
        
    }

    private IEnumerator DestroyFireBall()
    {
        yield return new WaitForSeconds( time );

        GetComponent<FireBallDie>().DestroyFireBall();
    }
}
