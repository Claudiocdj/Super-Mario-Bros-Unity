using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public static CanvasScript instance = null;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy( gameObject );

        DontDestroyOnLoad( gameObject );
    }
}
