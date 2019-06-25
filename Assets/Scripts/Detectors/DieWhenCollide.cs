using UnityEngine;

public class DieWhenCollide : DetectorComponent
{
    protected override void OnTrigger()
    {
        Destroy( gameObject );
    }
}
