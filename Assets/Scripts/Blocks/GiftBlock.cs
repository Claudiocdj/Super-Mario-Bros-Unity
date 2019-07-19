using UnityEngine;

public class GiftBlock : MonoBehaviour
{
    [SerializeField]
    private GameObject giftLevelOnePrefab;

    [SerializeField]
    private GameObject giftLevelTwoPrefab;

    [SerializeField]
    private GameObject blankBlockPrefab;

    [SerializeField]
    private GameObject summonGiftEffectPrefab;


    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += GiftEffect;
    }

    private void GiftEffect(GameObject mario)
    {
        GameObject item = SelectGift();
        
        if (item != null)
        {
            InstantiateSummonAnimation(item);

            if (blankBlockPrefab)
                Instantiate( blankBlockPrefab, transform.position, Quaternion.identity );

            Destroy( gameObject );
        }
    }

    private GameObject SelectGift()
    {
        if (GameObject.Find( "LittleMario" ) || GameObject.Find( "LittleMario(Clone)" ))
            return giftLevelOnePrefab;

        else if (GameObject.Find( "Mario" ) || GameObject.Find( "Mario(Clone)" ) ||
            GameObject.Find( "FireMario" ) || GameObject.Find( "FireMario(Clone)" ))
            return giftLevelTwoPrefab;

        return null;
    }

    private void InstantiateSummonAnimation(GameObject item)
    {
        GameObject n = Instantiate( summonGiftEffectPrefab, transform.position, Quaternion.identity );

        n.GetComponent<SummonGiftEffect>().SetGift( item );
    }
}
