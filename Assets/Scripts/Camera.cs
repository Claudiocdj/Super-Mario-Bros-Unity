using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;

    void Update()
    {
        if (player)
            transform.position = new Vector3(player.transform.position.x,
                transform.position.y, transform.position.z);

        else
            player = GameObject.FindWithTag( "Player" );
    }
}
