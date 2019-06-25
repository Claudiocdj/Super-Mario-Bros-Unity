using System;
using UnityEngine;

public abstract class Sensor : MonoBehaviour
{
    public string[] tagsWithCollide;

    public event Action<GameObject> Sign = delegate { };

    protected void Trigger(GameObject other)
    {
        foreach (string tag in tagsWithCollide)
            if (other.gameObject.tag == tag)
            {
                Sign( other.gameObject );

                return;
            }
    }
}
