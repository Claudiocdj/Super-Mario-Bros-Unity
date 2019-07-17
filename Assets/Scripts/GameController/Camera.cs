using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;

    void Update()
    {
        if (player)
        {
            Vector3 newPos = new Vector3( player.transform.position.x,
                transform.position.y, transform.position.z );

            if (newPos.x > transform.position.x)
                transform.position = newPos;
        }

        else
            player = GameObject.FindWithTag( "Player" );
    }
}
