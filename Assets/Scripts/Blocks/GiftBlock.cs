using UnityEngine;

public class GiftBlock : MonoBehaviour
{
    [SerializeField]
    private GameObject giftPrefab;

    [SerializeField]
    private GameObject blankBlockPrefab;

    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += GirfEffect;
    }

    private void GirfEffect(GameObject mario)
    {
        if (giftPrefab)
        {
            Instantiate( giftPrefab, transform.position + Vector3.up, Quaternion.identity );

            if(blankBlockPrefab)
                Instantiate( blankBlockPrefab, transform.position, Quaternion.identity );

            Destroy( gameObject );
        }
    }
}
