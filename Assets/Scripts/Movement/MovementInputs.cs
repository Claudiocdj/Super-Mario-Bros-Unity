﻿using UnityEngine;

public abstract class MovementInputs : MonoBehaviour
{
    [SerializeField]
    protected float speed = 1f;

    protected void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}