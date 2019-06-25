using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorOnTriggerExit : Sensor
{
    private void OnTriggerExit2D(Collider2D other)
    {
        Trigger( other.gameObject );
    }
}
