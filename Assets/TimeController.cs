using UnityEngine.UI;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    private Text timeText;

    private float timer;

    private void Awake()
    {
        timeText.text = "400";

        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1f)
        {
            timeText.text = ( int.Parse( timeText.text ) - 1f ).ToString();

            timer = 0f;
        }
    }
}
