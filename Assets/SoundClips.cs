using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClips : MonoBehaviour
{
    [SerializeField]
    private AudioClip jumpSmall;

    [SerializeField]
    private AudioClip jumpSuper;

    [SerializeField]
    private AudioClip bump;

    [SerializeField]
    private AudioClip breakBlock;

    [SerializeField]
    private AudioClip coin;

    private AudioSource audioController;

    void Start()
    {
        audioController = GetComponent<AudioSource>();
    }

    public void BreakBlock()
    {
        SetAudioClip( breakBlock );
    }

    public void Bump()
    {
        SetAudioClip( bump );
    }

    public void Coin()
    {
        SetAudioClip( coin );
    }

    public void Jump()
    {
        string mario = GameObject.FindWithTag( "Player" ).name;

        if (mario == "LittleMario" || mario == "LittleMario(Clone)")
            SetAudioClip( jumpSmall );

        else if (mario == "Mario" || mario == "Mario(Clone)" ||
                mario == "FireMario" || mario == "FireMario(Clone)")
            SetAudioClip( jumpSuper );
    }

    private void SetAudioClip(AudioClip audioClip)
    {
        audioController.clip = audioClip;

        audioController.Play();
    }
}
