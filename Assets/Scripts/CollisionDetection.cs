using System.Collections.Generic;
using UnityEngine;

public abstract class CollisionDetection : MonoBehaviour
{
    protected string[] tagsThatCollide = new string[] { "Ground", "Enemy" };
    
    protected abstract void FlipCollider();
}
