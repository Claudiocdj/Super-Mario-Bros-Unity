using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorCliff : Sensor
{
    [SerializeField]
    private int count;

    private void OnTriggerExit2D(Collider2D other)
    {
        count--;

        if(count == 0)
            Trigger( other.gameObject );
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        count++;
    }
}
