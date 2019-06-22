using UnityEngine;

public class MarioInputs : MonoBehaviour
{

    public float Horizontal { get; private set; }
    public bool JumpButton { get; private set; }

    private void Update()
    {
        Horizontal = Input.GetAxis( "Horizontal" );

        JumpButton = Input.GetAxis( "Fire1" ) > 0 ? true : false;
    }
}
