using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieByFireBallEffect : MonoBehaviour
{
    void Start()
    {
        Destroy( gameObject, 1f );
    }

    public void SetSprite(Sprite n)
    {
        transform.GetChild( 0 )
            .GetComponent<SpriteRenderer>()
            .sprite = n;
    }
}
