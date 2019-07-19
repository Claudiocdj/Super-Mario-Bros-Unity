using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonGiftEffect : MonoBehaviour
{
    private GameObject gift;

    void Start()
    {
        StartCoroutine( SummonEffect() );
    }

    private IEnumerator SummonEffect()
    {
        Sprite giftSprite = gift.GetComponent<SpriteRenderer>().sprite;

        transform.GetChild( 0 ).GetComponent<SpriteRenderer>().sprite = giftSprite;

        yield return new WaitForSeconds( 1f );

        Instantiate( gift, transform.position + Vector3.up, Quaternion.identity );

        Destroy( gameObject );
    }

    public void SetGift(GameObject n)
    {
        gift = n;
    }
}
