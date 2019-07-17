using UnityEngine;

public class HighScore : MonoBehaviour
{
    private int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt( "HighScore", 0 );
    }

    public int Get()
    {
        return highScore;
    }

    public void Set(int newScore)
    {
        if(newScore > highScore){
            PlayerPrefs.SetInt( "HighScore", newScore );

            highScore = newScore;
        }
    }
}
