using UnityEngine;

public class EnemyWallDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject wallDetectionPrefab;

    private void Awake()
    {
        GameObject wallDetection = Instantiate( wallDetectionPrefab,
                                                transform.position,
                                                Quaternion.identity );

        wallDetection.transform.parent = transform;

        GetComponentInChildren<WallDetection>().CollidedWithWall += OnCollision;
    }

    private void OnCollision()
    {
        bool movesToTheRight = GetComponent<BasicEnemyMovement>().movesToTheRight;

        GetComponent<BasicEnemyMovement>().movesToTheRight = !movesToTheRight;
    }
}
