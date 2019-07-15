using UnityEngine;

public class MarioUpgrade : MonoBehaviour
{

    public void Upgrade(GameObject upgradePrefab)
    {
        GameObject upgrade = Instantiate( upgradePrefab,
            transform.position, Quaternion.identity );

        upgrade.GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity;

        Destroy( gameObject );
    }
}