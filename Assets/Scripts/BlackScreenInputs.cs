using UnityEngine;
using UnityEngine.UI;

public class BlackScreenInputs : MonoBehaviour
{
    [SerializeField]
    private Text world;

    [SerializeField]
    private Text lives;

    public void Awake()
    {
        int marioLives = GameObject.FindWithTag( "GameController" )
            .GetComponent<LivesController>().Lives;

        string marioCurrentMapName = GameObject.FindWithTag( "Canvas" )
            .GetComponent<MapController>().mapName;

        lives.text = marioLives.ToString();

        world.text = "WORLD " + marioCurrentMapName;
    }
}
