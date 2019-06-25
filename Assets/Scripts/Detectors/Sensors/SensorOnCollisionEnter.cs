using UnityEngine;

public class SensorOnCollisionEnter : Sensor
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Trigger( other.gameObject );
    }
}
