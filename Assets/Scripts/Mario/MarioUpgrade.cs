using UnityEngine;

[RequireComponent(typeof( StarEffect ), typeof( Rigidbody2D ) )]
public class MarioUpgrade : MonoBehaviour
{
    private GameObject upgrade;

    private Rigidbody2D myRb;
    private StarEffect myStarEffect;

    private void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
        myStarEffect = GetComponent<StarEffect>();
    }

    public void Upgrade(GameObject upgradePrefab)
    {
        upgrade = Instantiate( upgradePrefab,
            transform.position, Quaternion.identity );

        PassFeatures();

        Destroy( gameObject );
    }

    private void PassFeatures()
    {
        CheckRigidBodyVelocity();

        CheckStarEffect();
    }

    private void CheckRigidBodyVelocity()
    {
        if (upgrade.GetComponent<Rigidbody2D>())
            upgrade.GetComponent<Rigidbody2D>().velocity = myRb.velocity;
    }

    private void CheckStarEffect()
    {
        if (myStarEffect && myStarEffect.ItsStarEffect)
            if (upgrade.GetComponent<StarEffect>())
                upgrade.GetComponent<StarEffect>().ContinueEffect( myStarEffect.CurrentTime );
    }
}