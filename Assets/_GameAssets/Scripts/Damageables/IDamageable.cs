using UnityEngine;

public interface IDamageable
{
    public void GiveDamage(Rigidbody playerRigidbody, Transform playerVisualTransform);
}