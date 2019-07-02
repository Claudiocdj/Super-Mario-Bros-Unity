using UnityEngine;

public class MarioUpgrade : MonoBehaviour
{

    public void Upgrade(GameObject upgradePrefab)
    {
        Instantiate( upgradePrefab, transform.position, Quaternion.identity );

        Destroy( gameObject );
    }
}