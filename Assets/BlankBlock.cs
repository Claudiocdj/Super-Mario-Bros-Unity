using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlankBlock : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += BlankBlockEffect;
    }

    private void BlankBlockEffect(GameObject mario)
    {
        //GameObject.FindWithTag( "SoundClips" )
        //                .GetComponent<SoundClips>()
        //                .Bump();
    }
}
