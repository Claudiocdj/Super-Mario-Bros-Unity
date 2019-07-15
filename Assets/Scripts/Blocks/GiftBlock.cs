using UnityEngine;

public class GiftBlock : MonoBehaviour
{
    [SerializeField]
    private GameObject giftLevelOnePrefab;

    [SerializeField]
    private GameObject giftLevelTwoPrefab;

    [SerializeField]
    private GameObject blankBlockPrefab;

    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += GiftEffect;
    }

    private void GiftEffect(GameObject mario)
    {
        GameObject item = null;

        if( GameObject.Find("LittleMario") || GameObject.Find( "LittleMario(Clone)" ) )
            item = giftLevelOnePrefab;
        
        else if (GameObject.Find( "Mario" ) || GameObject.Find( "Mario(Clone)" ) ||
            GameObject.Find( "FireMario" ) || GameObject.Find( "FireMario(Clone)" ))
            item = giftLevelTwoPrefab;
        
        if (item != null)
        {
            Instantiate( item, transform.position + Vector3.up, Quaternion.identity );

            if (blankBlockPrefab)
                Instantiate( blankBlockPrefab, transform.position, Quaternion.identity );

            Destroy( gameObject );
        }
    }
}
