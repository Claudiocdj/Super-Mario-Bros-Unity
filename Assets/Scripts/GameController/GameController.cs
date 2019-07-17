using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;

    [SerializeField]
    private int blackScreenTime = 3;

    [SerializeField]
    private int gameOverScreenTime = 3;

    [SerializeField]
    private int winScreenTime = 3;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        
        else if (instance != this)
            Destroy( gameObject );

        DontDestroyOnLoad( this );
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene( "BlackScreen" );

        StartCoroutine( BlackScreenTimer( sceneName ) );
    }

    private IEnumerator BlackScreenTimer(string sceneName)
    {
        yield return new WaitForSeconds( blackScreenTime );

        SceneManager.LoadScene( sceneName );

        GameObject.FindWithTag( "Canvas" )
            .GetComponent<TimeController>()
            .StartCounter();
    }

    public void ReloadScene()
    {
        LoadScene( SceneManager.GetActiveScene().name );
    }

    public void ReloadScene(float timer)
    {
        StartCoroutine( TimeToReloadCoroutine(timer) );
    }

    private IEnumerator TimeToReloadCoroutine(float timer)
    {
        yield return new WaitForSeconds( timer );

        if (GetComponent<LivesController>().Lives <= 0)
            GameOver();
        else
            ReloadScene();
    }

    public void GameOver()
    {
        SceneManager.LoadScene( "GameOverScreen" );

        ResetGame();

        StartCoroutine( GameOverTimer() );
    }

    public void Win()
    {
        StartCoroutine( WinTimer() );
    }

    private void ResetGame()
    {
        GameObject.FindWithTag( "Canvas" )
            .GetComponent<CanvasScript>()
            .ResetCanvas();

        GetComponent<LivesController>().ResetLives();
    }

    private IEnumerator GameOverTimer()
    {
        yield return new WaitForSeconds( gameOverScreenTime );

        SceneManager.LoadScene( "FirstScene" );
    }

    private IEnumerator WinTimer()
    {
        yield return new WaitForSeconds( winScreenTime );

        ResetGame();

        SceneManager.LoadScene( "FirstScene" );
    }
}
