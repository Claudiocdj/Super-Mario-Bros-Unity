using UnityEngine;

public class DeleteAfterATime : MonoBehaviour
{
    [SerializeField]
    private float time = 2f;

    void Start()
    {
        Destroy( gameObject, time );   
    }
}
