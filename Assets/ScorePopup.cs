using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePopup : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine( PopupEffect() );

        GetComponent<Renderer>().sortingLayerName = "items";
    }

    public void SetText(int points)
    {
        GetComponent<TextMesh>().text = points.ToString();
    }

    private IEnumerator PopupEffect()
    {
        for(int i = 0; i < 100; i++)
        {
            yield return new WaitForSeconds( 0.01f );
            transform.position += Vector3.up * 0.02f;
        }

        Destroy( gameObject );
    }
}
