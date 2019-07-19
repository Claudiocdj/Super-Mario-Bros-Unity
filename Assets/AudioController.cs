using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private AudioClip normalTheme;

    [SerializeField]
    private AudioClip starTheme;

    private AudioSource controller;

    private void Awake()
    {
        controller = GetComponent<AudioSource>();
    }

    public void PlayStarTheme()
    {
        controller.clip = starTheme;

        controller.Play();
    }

    public void StopStarTheme()
    {
        controller.clip = normalTheme;

        controller.Play();
    }
}
