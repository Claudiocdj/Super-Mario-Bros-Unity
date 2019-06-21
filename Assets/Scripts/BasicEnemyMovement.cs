using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{
    public bool movesToTheRight = true;

    [SerializeField]
    private float speed = 1f;

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 direction = movesToTheRight ? Vector3.right : Vector3.left;

        transform.position += direction * speed * Time.deltaTime;
    }
}
