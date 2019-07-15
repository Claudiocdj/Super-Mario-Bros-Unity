using UnityEngine;

public class CoinBlock : MonoBehaviour
{
    [SerializeField]
    private GameObject blankBlockPrefab;
    [SerializeField]
    private int coinsCount = 1;

    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += CoinEffect;
    }

    private void CoinEffect(GameObject mario)
    {
        Debug.Log( "plim" );

        GameObject canvas = GameObject.FindWithTag( "Canvas" );

        canvas.GetComponent<CoinsController>().AddCoins( 1 );

        if (GetComponent<ScoreGiven>())
            GetComponent<ScoreGiven>().SetScore();

        coinsCount--;

        if(coinsCount <= 0)
        {
            if (blankBlockPrefab)
                Instantiate( blankBlockPrefab, transform.position, Quaternion.identity );

            Destroy( gameObject );
        }
    }
}
