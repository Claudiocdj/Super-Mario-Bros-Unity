using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private int score = 0;

    private void Awake()
    {
        scoreText.text = "000000";
    }

    public void AddScore(int points)
    {
        score += points;

        if (score < 10)
            scoreText.text = "00000" + score.ToString();

        else if (score < 100)
            scoreText.text = "0000" + score.ToString();

        else if (score < 1000)
            scoreText.text = "000" + score.ToString();

        else if (score < 10000)
            scoreText.text = "00" + score.ToString();

        else if (score < 100000)
            scoreText.text = "0" + score.ToString();

        else if (score < 1000000)
            scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        GetComponent<HighScore>().Set( score );

        scoreText.text = "000000";

        score = 0;
    }

    public void Win()
    {
        StartCoroutine( WinScoreEffect() );
    }

    private IEnumerator WinScoreEffect()
    {
        TimeController time = GetComponent<TimeController>();

        int currentTime = time.GetCurrentTime();

        time.StopTimer();

        for (int i = 0; i < currentTime - (currentTime % 5); i+=5)
        {
            AddScore( 50 * 5);

            time.SetTimeText( currentTime - i );

            yield return new WaitForSeconds( 0.01f );
        }

        for(int i = 0; i <= currentTime % 5; i++)
        {
            AddScore( 50 );

            time.SetTimeText( (currentTime % 5) - i );

            yield return new WaitForSeconds( 0.01f );
        }
    }
}
