using UnityEngine;

public class FireBallLauncher : MonoBehaviour
{
    [SerializeField]
    private GameObject fireBallPrefab;

    private void Update()
    {
        if (Input.GetButtonDown( "Fire2" ))
            Attack();
    }

    private void Attack()
    {
        if(GameObject.FindGameObjectsWithTag("FireBall").Length < 4)
        {
            bool facingLeft = GetComponent<SpriteRenderer>().flipX;

            Vector3 newPos = transform.position;

            newPos += facingLeft ? Vector3.left : Vector3.right;

            GameObject fireBall = Instantiate( fireBallPrefab, newPos, Quaternion.identity );

            fireBall.GetComponent<AiInputs>().movingToTheLeft = facingLeft;
        }
    }
}
