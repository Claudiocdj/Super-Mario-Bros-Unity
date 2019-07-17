using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    private Text timeText;

    [SerializeField]
    private int time;

    private Coroutine cr = null;

    private int pausedTime;

    private void Awake()
    {
        timeText.text = time.ToString();
    }

    public void StartCounter()
    {
        if (cr != null)
            StopCoroutine( cr );
        
        cr = StartCoroutine( StartCounterCoroutine() );
    }

    public void StopTimer()
    {
        if (cr != null)
            StopCoroutine( cr );

        timeText.text = "400";
    }

    private IEnumerator StartCounterCoroutine()
    {

        int timer = time;

        while (timer >= 0)
        {
            timeText.text = timer.ToString();

            yield return new WaitForSeconds( 1f );

            timer--;
        }

        TimesUp();
    }

    private void TimesUp()
    {
        MarioDeath marioDeath = GameObject.FindWithTag( "Player" )
                    .GetComponent<MarioDeath>();

        if (marioDeath)
            marioDeath.Active();
    }

    public int GetCurrentTime()
    {
        return int.Parse( timeText.text );
    }

    public void SetTimeText(int num)
    {
        timeText.text = num.ToString();
    }
}
