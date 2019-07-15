using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof( MarioInvensibleEffect ), typeof( SpriteRenderer) )]
public class StarEffect : MonoBehaviour
{
    public bool ItsStarEffect { get; set; }

    [SerializeField]
    private int effectTime = 30;

    public int CurrentTime { get; private set; }

    public void Active()
    {
        StartCoroutine( StarEffectCoroutine( effectTime ) );
    }

    public void ContinueEffect(int pastTime)
    {
        StartCoroutine( StarEffectCoroutine( effectTime - pastTime ) );
    }

    private IEnumerator StarEffectCoroutine(int time)
    {
        ItsStarEffect = true;

        GetComponent<MarioInvensibleEffect>().IsInvensible = true;

        SpriteRenderer mySprite = GetComponent<SpriteRenderer>();

        Color myColor = mySprite.color;

        for (int i = 0; i <= time * 5; i++)
        {
            CurrentTime = i/5;

            mySprite.color = new Color( 255f, 0f, 0f, 1f );

            yield return new WaitForSeconds( 0.1f );

            mySprite.color = new Color( 255f, 255f, 255f, 1f );

            yield return new WaitForSeconds( 0.1f );
        }

        GetComponent<MarioInvensibleEffect>().IsInvensible = false;

        ItsStarEffect = false;
    }
}
