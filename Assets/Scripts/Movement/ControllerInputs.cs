using UnityEngine;

public class ControllerInputs : MovementInputs
{
    private void FixedUpdate()
    {
        Vector3 direction = Vector3.right * Input.GetAxis( "Horizontal" );

        Move( direction );
    }
}
