using UnityEngine;

public class ControllerInputs : MovementByRigidBody
{
    private Vector2 direction;

    public Vector2 vel;

    public bool InputRight { get; private set; }

    public bool InputLeft { get; private set; }

    private void Update()
    {
        vel = GetComponent<Rigidbody2D>().velocity;

        InputRight = Input.GetKey( KeyCode.RightArrow );

        InputLeft = Input.GetKey( KeyCode.LeftArrow );

        if (InputLeft)
            Move( Vector2.left );

        else if (InputRight)
            Move( Vector2.right );

        else
            Move( Vector2.zero );
    }
}
