using UnityEngine;
using UnityEngine.UI;

public class CoinsController : MonoBehaviour
{
    [SerializeField]
    private Text coinsText;

    private void Awake()
    {
        coinsText.text = "00";
    }

    public void AddCoins(int coins)
    {
        int currentPoints = int.Parse( coinsText.text );

        int n = currentPoints + coins;

        if (n < 10)
            coinsText.text = "0" + n.ToString();

        else if (n < 100)
            coinsText.text = n.ToString();

        else if(n >= 100)
        {
            GameObject.FindWithTag( "GameController" )
                .GetComponent<LivesController>()
                .AddsLife();

            ResetCoins();
        }
    }

    public void ResetCoins()
    {
        coinsText.text = "00";
    }
}
