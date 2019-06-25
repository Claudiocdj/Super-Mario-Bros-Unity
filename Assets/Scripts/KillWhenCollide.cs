using UnityEngine;

public class KillWhenCollide : MonoBehaviour
{
    private string[] tagsWithCollide = new string[] { "Enemy" };

    private void OnCollisionEnter2D(Collision2D other)
    {
        foreach (string tag in tagsWithCollide)
            if (other.gameObject.tag == tag)
            {
                Destroy( other.gameObject );

                Destroy( gameObject );
            }
    }
}
