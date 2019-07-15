using UnityEngine;

public class ControllerInputs : MovementByRigidBody
{
    private Vector2 direction;

    public Vector2 vel;

    private void Update()
    {
        vel = GetComponent<Rigidbody2D>().velocity;

        if (Input.GetKey( KeyCode.LeftArrow ))
            Move( Vector2.left );

        else if (Input.GetKey( KeyCode.RightArrow ))
            Move( Vector2.right );

        else
            Move( Vector2.zero );
    }
}
