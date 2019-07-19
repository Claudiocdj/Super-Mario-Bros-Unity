using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioInvensibleEffect : MonoBehaviour
{
    public bool IsInvensible { get; set; }

    [SerializeField]
    private float effectTime = 3f;

    [SerializeField]
    private AudioClip powerDownClip;

    private void Awake()
    {
        IsInvensible = false;
    }

    public void InvensibleEffect()
    {
        StartCoroutine( InvensibleEffectCoroutine() );
    }

    private IEnumerator InvensibleEffectCoroutine()
    {
        SetAudio();

        IsInvensible = true;

        SpriteRenderer mySprite = GetComponent<SpriteRenderer>();

        Color myColor = mySprite.color;

        for (int i = 0; i <= effectTime*5; i++)
        {
            mySprite.color = new Color( myColor.r, myColor.g, myColor.b, 0f );

            yield return new WaitForSeconds( 0.1f );

            mySprite.color = new Color( myColor.r, myColor.g, myColor.b, 1f );

            yield return new WaitForSeconds( 0.1f );
        }

        IsInvensible = false;
    }

    private void SetAudio()
    {

        AudioSource audio = GetComponent<AudioSource>();

        audio.clip = powerDownClip;

        audio.Play();
    }
}
