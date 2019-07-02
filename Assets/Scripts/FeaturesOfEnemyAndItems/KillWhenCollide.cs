using UnityEngine;

public class KillWhenCollide : DetectorToInstantiate
{
    protected override void OnTrigger(GameObject other) {
        Destroy( other.gameObject );

        Destroy( gameObject );
    }
}
