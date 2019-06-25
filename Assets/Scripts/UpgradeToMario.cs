using UnityEngine;

public class UpgradeToMario : DetectorToInstantiate
{
    protected override void OnTrigger(GameObject other)
    {
        /*
        if (other.tag == "Player")
            other.GetComponent<Upgrade>().Mario;
        */

        Destroy( gameObject );
    }
}
