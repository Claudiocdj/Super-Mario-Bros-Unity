using UnityEngine;

public class FlipSensor : MonoBehaviour
{
    private void Start()
    {
        AiInputs movement = transform.parent.gameObject.GetComponent<AiInputs>();

        if(movement != null && !movement.movingToTheLeft)
            FlipColliderComponent();
    }

    public void FlipColliderComponent()
    {
        BoxCollider2D myBc = GetComponent<BoxCollider2D>();

        myBc.offset = new Vector2( myBc.offset.x * -1f, myBc.offset.y );
    }
}
