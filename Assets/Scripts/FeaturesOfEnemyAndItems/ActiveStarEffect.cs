using UnityEngine;

public class ActiveStarEffect : DetectorToInstantiate
{
    protected override void OnTrigger(GameObject other)
    {
        
        if (other.tag == "Player")
            other.GetComponent<StarEffect>().Active();

        Destroy( gameObject );
    }
}
