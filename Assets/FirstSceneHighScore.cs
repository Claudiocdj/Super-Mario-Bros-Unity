using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSceneHighScore : MonoBehaviour
{
    [SerializeField]
    private Text highScore; 

    private void Awake()
    {
        int n = GameObject.FindWithTag( "Canvas" )
            .GetComponent<HighScore>().Get();

        highScore.text = "TOP - ";

        if (n < 10)
            highScore.text += "00000" + n.ToString();

        else if (n < 100)
            highScore.text += "0000" + n.ToString();

        else if (n < 1000)
            highScore.text += "000" + n.ToString();

        else if (n < 10000)
            highScore.text += "00" + n.ToString();

        else if (n < 100000)
            highScore.text += "0" + n.ToString();

        else if (n < 1000000)
            highScore.text += n.ToString();
    }
}
