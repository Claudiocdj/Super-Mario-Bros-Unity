using UnityEngine;

public class EnemyCliffDetection : MonoBehaviour
{
    [SerializeField]
    private GameObject cliffDetectionPrefab;

    private void Awake()
    {
        GameObject wallDetection = Instantiate( cliffDetectionPrefab,
                                                transform.position,
                                                Quaternion.identity );

        wallDetection.transform.parent = transform;

        GetComponentInChildren<CliffDetection>().CliffDetected += OnCliffDetected;
    }

    private void OnCliffDetected()
    {
        bool movesToTheRight = GetComponent<BasicEnemyMovement>().movesToTheRight;

        GetComponent<BasicEnemyMovement>().movesToTheRight = !movesToTheRight;
    }
}
