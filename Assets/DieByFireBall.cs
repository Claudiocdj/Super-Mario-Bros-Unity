using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieByFireBall : MonoBehaviour
{
    [SerializeField]
    private GameObject deadEnemyPrefab;

    public void DestroyEnemy()
    {
        GetComponent<ScoreGiven>().SetScore();

        GameObject obj = Instantiate( deadEnemyPrefab, 
            transform.position, Quaternion.identity );

        Sprite mySprite = GetComponent<SpriteRenderer>().sprite;

        obj.GetComponent<DieByFireBallEffect>().SetSprite( mySprite );

        Destroy( gameObject );
    }
}
