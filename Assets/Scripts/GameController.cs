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

        GameObject.FindWithTag( "Canvas" )
            .GetComponent<TimeController>()
            .StopTimer();

        StartCoroutine( GameOverTimer() );
    }

    private IEnumerator GameOverTimer()
    {
        yield return new WaitForSeconds( gameOverScreenTime );

        GetComponent<LivesController>().ResetLives();

        SceneManager.LoadScene( "FirstScene" );
    }
}
