using UnityEngine;

public class Fireball : MonoBehaviour, IProjectile
{
    public void Shoot()
    {
        Debug.Log($"Fireball launched!");
    }
}
