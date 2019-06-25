using UnityEngine;

public abstract class DetectorComponent : MonoBehaviour
{
    [SerializeField]
    protected GameObject[] detectorsPrefab;
    [SerializeField]
    private string[] tagWithCollide = new string[] { "Ground", "Enemy" };

    protected GameObject[] detectors;

    protected virtual void Awake()
    {
        int i = 0;

        detectors = new GameObject[detectorsPrefab.Length];

        foreach (GameObject detector in detectorsPrefab)
        {
            detectors[i] = Instantiate( detector, transform.position, Quaternion.identity );

            detectors[i].transform.parent = transform;

            detectors[i].GetComponent<Sensor>().tagsWithCollide = tagWithCollide;

            detectors[i].GetComponent<Sensor>().Sign += OnTrigger;

            i++;
        }
    }

    protected abstract void OnTrigger();
}
