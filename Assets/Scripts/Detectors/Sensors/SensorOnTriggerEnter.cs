using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorOnTriggerEnter : Sensor
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Trigger( other.gameObject );
    }
}
