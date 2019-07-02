using UnityEngine;

public class OwnBoxColliderDetector : MonoBehaviour
{
    private void Start()
    {
        BoxCollider2D parentCol = transform.parent.GetComponent<BoxCollider2D>();

        BoxCollider2D myCol = GetComponent<BoxCollider2D>();

        gameObject.tag = transform.parent.tag;

        gameObject.layer = transform.parent.gameObject.layer;

        myCol.offset = parentCol.offset;

        myCol.size = parentCol.size;

        parentCol.enabled = false;
    }
}