using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            if(other.GetComponent<AiInputs>())
                other.transform.GetComponent<AiInputs>().enabled = true;
            else
                other.transform.parent.GetComponent<AiInputs>().enabled = true;
        }
    }
}
