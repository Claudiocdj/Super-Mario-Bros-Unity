using UnityEngine;

[RequireComponent(typeof(ScoreGiven))]
public class UpgradeToMario : DetectorToInstantiate
{
    [SerializeField]
    private GameObject upgradePrefab;
    
    protected override void OnTrigger(GameObject other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<MarioUpgrade>().Upgrade( upgradePrefab );

            GetComponent<ScoreGiven>().SetScore();

            Destroy( gameObject );
        }
    }
}
