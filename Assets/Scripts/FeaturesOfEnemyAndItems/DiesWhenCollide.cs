using UnityEngine;

public class DiesWhenCollide : DetectorToInstantiate
{
    protected override void OnTrigger(GameObject other)
    {
        GetComponent<FireBallDie>().DestroyFireBall();
    }
}
