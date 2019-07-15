using UnityEngine;

public class AiInputs : MovementByTransform
{
    public bool movingToTheLeft = true;

    private void FixedUpdate()
    {
        Vector3 direction = movingToTheLeft ? Vector3.left : Vector3.right;

        Move( direction );
    }
}
