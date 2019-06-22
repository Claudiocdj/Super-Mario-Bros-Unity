using UnityEngine;

public class ComponentCliffDetection : ComponentCollisionDetection
{
    protected override void Awake()
    {
        base.Awake();

        //GetComponentInChildren<CliffDetection>().CliffDetected += OnCollision;
    }

    protected override void OnCollision()
    {
        base.OnCollision();
    }
}
