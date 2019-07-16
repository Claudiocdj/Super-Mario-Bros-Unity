using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesController : MonoBehaviour
{
    [SerializeField]
    private int initialLives = 3;

    [SerializeField]
    public int Lives { get; private set; }

    private void Awake()
    {
        Lives = initialLives;
    }

    public void AddsLife()
    {
        Lives++;
    }

    public void DecreasesLife()
    {
        Lives--;
    }

    public void ResetLives()
    {
        Lives = initialLives;
    }
}
