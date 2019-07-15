using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.parent)
            Destroy( other.transform.parent.gameObject );
        else
            Destroy( other.gameObject );
    }
}
