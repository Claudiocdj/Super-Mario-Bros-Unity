using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public static CanvasScript instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy( gameObject );

        DontDestroyOnLoad( gameObject );
    }

    public void ResetCanvas()
    {
        GetComponent<ScoreController>().ResetScore();

        GetComponent<TimeController>().StopTimer();

        GetComponent<CoinsController>().ResetCoins();

        GetComponent<MapController>().mapName = "1-1";
    }
}
