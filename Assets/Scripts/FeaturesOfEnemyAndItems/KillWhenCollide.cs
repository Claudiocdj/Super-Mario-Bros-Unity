using UnityEngine;

public class KillWhenCollide : DetectorToInstantiate
{
    protected override void OnTrigger(GameObject other) {

        other.GetComponent<DieByFireBall>().DestroyEnemy();

        GetComponent<FireBallDie>().DestroyFireBall();
    }
}
