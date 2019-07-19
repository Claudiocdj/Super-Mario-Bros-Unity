using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMarioEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag( "SoundClips" )
            .GetComponent<AudioSource>()
            .Stop();
    }
}
