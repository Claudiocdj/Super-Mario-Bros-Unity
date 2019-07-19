using UnityEngine;

public class MarioDamage : MonoBehaviour
{
    [SerializeField]
    private GameObject littleMarioPrefab;

    [SerializeField]
    private AudioClip powerDownClip;

    private bool isLittleMario = false;

    private void Awake()
    {
        if (gameObject.name == "LittleMario(Clone)" ||
            gameObject.name == "LittleMario")
            isLittleMario = true;
    }

    public void Damage()
    {
        if (!isLittleMario && littleMarioPrefab)
        {
            SetAudio();

            GameObject newMario = Instantiate( littleMarioPrefab, transform.position,
                                                Quaternion.identity );

            MarioInvensibleEffect invensibleEffect = newMario.GetComponent<MarioInvensibleEffect>();

            if (invensibleEffect)
                invensibleEffect.InvensibleEffect();

            Destroy( gameObject );
        }
        else if(GetComponent<MarioDeath>())
            GetComponent<MarioDeath>().Active();
    }

    private void SetAudio()
    {
        
        AudioSource audio = GetComponent<AudioSource>();

        audio.clip = powerDownClip;

        audio.Play();
        Debug.Log( audio );

    }
}
