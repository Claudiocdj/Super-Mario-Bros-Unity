using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSwingEffect : MonoBehaviour
{
    private SpriteRenderer blockSprite;

    private void Awake()
    {
        blockSprite = transform.GetChild( 0 ).GetComponent<SpriteRenderer>();

        Debug.Log(GetComponent<Animator>().GetCurrentAnimatorClipInfo( 0 ).Length);
    }

    public void SetSpriteBlock(Sprite sprite)
    {
        blockSprite.sprite = sprite;
    }
}
