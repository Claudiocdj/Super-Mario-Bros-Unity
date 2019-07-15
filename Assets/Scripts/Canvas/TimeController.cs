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
            if(int.Parse( timeText.text ) - 1f < 0f)
                TimesUp();

            else
            {
                timeText.text = ( int.Parse( timeText.text ) - 1f ).ToString();

                timer = 0f;
            }
            
        }
    }

    private void TimesUp()
    {
        MarioDeath marioDeath = GameObject.FindWithTag( "Player" )
                    .GetComponent<MarioDeath>();

        if (marioDeath)
            marioDeath.Active();
    }
}
