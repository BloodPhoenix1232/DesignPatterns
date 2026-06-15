using UnityEngine;

public class Arrow : MonoBehaviour, IProjectile
{
    public void Shoot()
    {
        Debug.Log($"Arrow launched!");
    }
}
