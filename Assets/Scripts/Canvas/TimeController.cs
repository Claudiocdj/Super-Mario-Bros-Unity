using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    private Text timeText;

    [SerializeField]
    private int time;

    public bool pauseCounter = false;

    private Coroutine cr = null;

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
            if (pauseCounter)
                continue;

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
}
