using UnityEngine;

public class MarioRun : MonoBehaviour
{
    private MovementInputs marioMovement;

    private void Awake()
    {
        marioMovement = GetComponent<MovementInputs>();
    }

    private void Update()
    {
        if (Input.GetButtonDown( "Fire2" ))
            marioMovement.speed += 2f;

        if(Input.GetButtonUp("Fire2"))
            marioMovement.speed -= 2f;
    }
}
