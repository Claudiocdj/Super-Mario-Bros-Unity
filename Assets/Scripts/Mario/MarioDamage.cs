using UnityEngine;

public class MarioDamage : MonoBehaviour
{
    [SerializeField]
    private GameObject littleMarioPrefab;

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
            GameObject newMario = Instantiate( littleMarioPrefab, transform.position,
                                                Quaternion.identity );

            MarioInvensibleEffect invensibleEffect = newMario.GetComponent<MarioInvensibleEffect>();

            if(invensibleEffect)
                invensibleEffect.InvensibleEffect();
        }

        Destroy( gameObject );
    }
}
