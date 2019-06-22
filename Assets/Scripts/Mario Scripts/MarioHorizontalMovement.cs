using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MarioInputs))]
public class MarioHorizontalMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    private MarioInputs inputs;

    private void Awake()
    {
        inputs = GetComponent<MarioInputs>();
    }

    private void Update()
    {
        transform.position += Vector3.right * inputs.Horizontal * speed * Time.deltaTime;
    }
}
