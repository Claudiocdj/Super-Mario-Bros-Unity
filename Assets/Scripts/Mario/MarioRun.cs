using UnityEngine;

public class MarioRun : MonoBehaviour
{
    private MovementByRigidBody marioMovement;

    private void Awake()
    {
        marioMovement = GetComponent<MovementByRigidBody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown( "Fire2" ))
            marioMovement.speed += 2f;

        if(Input.GetButtonUp("Fire2"))
            marioMovement.speed -= 2f;
    }
}
