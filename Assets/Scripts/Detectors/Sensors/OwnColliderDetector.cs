using UnityEngine;

public class OwnColliderDetector : MonoBehaviour
{
    private void Start()
    {
        CircleCollider2D parentCol = transform.parent.GetComponent<CircleCollider2D>();

        CircleCollider2D myCol = GetComponent<CircleCollider2D>();

        gameObject.tag = transform.parent.tag;

        gameObject.layer = transform.parent.gameObject.layer;

        myCol.offset = parentCol.offset;

        myCol.radius = parentCol.radius;
    }
}
