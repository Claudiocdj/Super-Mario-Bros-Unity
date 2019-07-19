using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioDeath : MonoBehaviour
{
    private GameObject gc;

    [SerializeField]
    private GameObject deadMarioPrefab;

    public void Active()
    {
        gc = GameObject.FindWithTag( "GameController" );

        gc.GetComponent<LivesController>().DecreasesLife();

        gc.GetComponent<GameController>().ReloadScene( 3f );

        Instantiate( deadMarioPrefab, transform.position, Quaternion.identity );

        Destroy( gameObject );
    }
}
