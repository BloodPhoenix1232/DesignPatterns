using System;
using UnityEngine;

public class ProjectileFactory : MonoBehaviour
{
    [SerializeField] private GameObject _arrowPrefab;
    [SerializeField] private GameObject _fireballPrefab;
    [SerializeField] private GameObject _iceBoltPrefab;

    public IProjectile Create(ProjectileType type)
    {
        switch (type)
        {
            case ProjectileType.Arrow:
                return Instantiate(_arrowPrefab).GetComponent<IProjectile>();
            case ProjectileType.Fireball:
                return Instantiate(_fireballPrefab).GetComponent<IProjectile>();
            case ProjectileType.IceBolt:
                return Instantiate(_iceBoltPrefab).GetComponent<IProjectile>();
            default:
                throw new NotImplementedException($"Projectile type {type} is not implemented");
        }
    }
}
