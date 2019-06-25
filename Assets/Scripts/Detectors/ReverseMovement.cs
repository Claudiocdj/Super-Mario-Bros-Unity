using UnityEngine;

public class ReverseMovement : DetectorComponent
{
    public bool flipGameObject = true;

    protected override void OnTrigger()
    {
        FlipCollidersComponents();

        ReverseMove();

        if(flipGameObject)
        FlipGameObject();
    }

    private void FlipCollidersComponents()
    {
        foreach (GameObject detector in detectors)
        {
            FlipSensor flipDetector = detector.GetComponent<FlipSensor>();

            if(flipDetector != null)
                flipDetector.FlipColliderComponent();
        }
    }

    private void ReverseMove()
    {
        AiInputs move = GetComponent<AiInputs>();

        move.movingToTheLeft = !move.movingToTheLeft;
    }

    private void FlipGameObject()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
    }
}
