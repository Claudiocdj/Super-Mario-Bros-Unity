using UnityEngine;

public class ScoreGiven : MonoBehaviour
{
    [SerializeField]
    private GameObject scorePopupPrefab;

    [SerializeField]
    private int scorePoints;

    public void SetScore()
    {
        AddScorePoints();

        CreateScorePopup();
    }

    private void AddScorePoints()
    {
        GameObject canvas = GameObject.FindWithTag( "Canvas" );

        canvas.GetComponent<ScoreController>().AddScore( scorePoints );
    }

    private void CreateScorePopup()
    {
        GameObject popup = Instantiate( scorePopupPrefab,
            transform.position + Vector3.up, Quaternion.identity );

        popup.GetComponent<ScorePopup>().SetText( scorePoints );
    }
}
