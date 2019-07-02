using UnityEngine;

public class DropItemWhenDying : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    private void Awake()
    {
        GetComponent<DamageWhenJumpOnTheHead>().DamageEnemy += DropItem;
    }

    private void DropItem()
    {
        if(item != null)
            Instantiate( item, transform.position, Quaternion.identity );

        Destroy( gameObject );
    }
}
