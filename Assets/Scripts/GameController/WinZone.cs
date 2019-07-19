using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            DesablePlayerInputs();

            GetComponent<AudioSource>().Play();

            GameObject.FindWithTag( "Canvas" )
                .GetComponent<ScoreController>()
                .Win();
                
            GameObject.FindWithTag( "GameController" )
                .GetComponent<GameController>()
                .Win();
        }
    }

    private void DesablePlayerInputs()
    {
        GameObject.FindWithTag( "Player" )
            .GetComponent<JumpControllerInputs>().enabled = false;

        GameObject.FindWithTag( "Player" )
            .GetComponent<ControllerInputs>().enabled = false;
    }
}
