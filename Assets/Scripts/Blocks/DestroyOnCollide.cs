using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += DestroyEffect;
    }

    private void DestroyEffect(GameObject mario)
    {
        if(mario.name == "Mario" || mario.name == "Mario (Clone)" ||
            mario.name == "FireMario" || mario.name == "FireMario (Clone)")
            Destroy( gameObject );
    }
}
