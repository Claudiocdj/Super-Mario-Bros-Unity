using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ComponentCollisionDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject detectionPrefab;

    [SerializeField]
    private string[] tagsWithCollide;

    protected virtual void Awake()
    {
        GameObject detectionObject = Instantiate( detectionPrefab,
                                                transform.position,
                                                Quaternion.identity );

        detectionObject.transform.parent = transform;
    }

    protected virtual void OnCollision()
    {
        BasicMovement enemyMov = GetComponent<BasicMovement>();

        bool movesToTheLeft = enemyMov.movesToTheLeft;

        enemyMov.movesToTheLeft = !movesToTheLeft;

        enemyMov.FlipSprite();
    }
}
