using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioDeath : MonoBehaviour
{
    private GameObject gc;

    public void Active()
    {
        gc = GameObject.FindWithTag( "GameController" );

        gc.GetComponent<LivesController>().DecreasesLife();

        gc.GetComponent<GameController>().ReloadScene( 2f );

        Destroy( gameObject );
    }
}
