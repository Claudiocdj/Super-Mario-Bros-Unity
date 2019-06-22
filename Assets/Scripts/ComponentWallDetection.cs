using UnityEngine;

public class ComponentWallDetection : MonoBehaviour, IFlipCollisionDetection
{
    [SerializeField]
    private GameObject detectionPrefab;

    [SerializeField]
    private string[] tagsWithCollide;

    private void Awake()
    {
        GameObject detectionObject = Instantiate( detectionPrefab,
                                                transform.position,
                                                Quaternion.identity );

        detectionObject.transform.parent = transform;

        CollisionDetection colDetection = detectionObject.GetComponent<CollisionDetection>();

        colDetection.Collided += OnCollision;

        colDetection.tagsThatCollide = tagsWithCollide;
    }

    private void OnCollision()
    {
        BasicMovement enemyMov = GetComponent<BasicMovement>();

        bool movesToTheLeft = enemyMov.movesToTheLeft;

        enemyMov.movesToTheLeft = !movesToTheLeft;

        enemyMov.FlipSprite();
    }

    public void FlipBoxCollider()
    {

    }
}
