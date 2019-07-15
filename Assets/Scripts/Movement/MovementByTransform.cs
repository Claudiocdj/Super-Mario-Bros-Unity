using UnityEngine;

public abstract class MovementByTransform : MonoBehaviour
{
    public float speed = 1f;

    protected void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
