using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    [SerializeField]
    private GameObject breakingBlock;

    [SerializeField]
    private AudioClip bumpSound;

    private void Awake()
    {
        GetComponent<CollideWithMario>().BricksEffect += DestroyEffect;
    }

    private void DestroyEffect(GameObject mario)
    {
        if (mario.name == "Mario" || mario.name == "Mario(Clone)" ||
            mario.name == "FireMario" || mario.name == "FireMario(Clone)")
        {
            Instantiate( breakingBlock, transform.position, Quaternion.identity );

            Destroy( gameObject );
        }
        else
        {
            if (bumpSound)
                SetAudio( bumpSound );
        }
    }

    private void SetAudio(AudioClip clip)
    {
        AudioSource audio = GetComponent<AudioSource>();

        if (audio)
        {
            audio.clip = clip;

            audio.Play();
        }
    }
}
