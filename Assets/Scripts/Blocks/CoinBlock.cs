using UnityEngine;

public class CoinBlock : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += CoinEffect;
    }

    private void CoinEffect(GameObject mario)
    {
        Debug.Log( "plim" );
    }
}
