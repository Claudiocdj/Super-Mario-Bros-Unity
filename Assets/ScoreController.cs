using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private void Awake()
    {
        scoreText.text = "000000";
    }

    public void AddScore(int points)
    {
        int currentPoints = int.Parse( scoreText.text );

        int n = currentPoints + points;

        if (n < 10)
            scoreText.text = "00000" + n.ToString();

        else if (n < 100)
            scoreText.text = "0000" + n.ToString();

        else if (n < 1000)
            scoreText.text = "000" + n.ToString();

        else if (n < 10000)
            scoreText.text = "00" + n.ToString();

        else if (n < 100000)
            scoreText.text = "0" + n.ToString();

        else if (n < 1000000)
            scoreText.text = n.ToString();
    }
}
