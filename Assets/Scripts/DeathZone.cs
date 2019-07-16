using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<MarioDeath>().Active();
        }

        else if(other.transform.parent)
            Destroy( other.transform.parent.gameObject );
        else
            Destroy( other.gameObject );
    }
}
