using UnityEngine;

public class JumpControllerInputs : JumpInputs
{
    private void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
            Jump(gameObject);
    }
}