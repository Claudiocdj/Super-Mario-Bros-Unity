using UnityEngine;

public class FirstScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown( KeyCode.Return ))
            GameObject.FindWithTag( "GameController" )
                .GetComponent<GameController>().LoadScene( "map1-1" );
    }
}
