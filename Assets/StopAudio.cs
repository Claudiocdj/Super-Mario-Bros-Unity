using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour
{
    private AudioSource[] allAudioSources;

    private bool isMute = false;

    private void Update()
    {
        if (Input.GetKeyDown( KeyCode.Q ))
            AllAudios();

    }

    void AllAudios()
    {
        if(isMute)
            AudioListener.volume = 1f;
        else
            AudioListener.volume = 0f;

        isMute = !isMute;
    }

}
