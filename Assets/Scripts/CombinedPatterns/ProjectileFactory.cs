using System;
using UnityEngine;

namespace Combined 
{
    public class ProjectileFactory : MonoBehaviour
    {
        [SerializeField] private GameObject _arrowPrefab;
        [SerializeField] private GameObject _fireballPrefab;
        [SerializeField] private GameObject _bulletPrefab;

        public IProjectile Create(ProjectileType type)
        {
            switch (type)
            {
                case ProjectileType.Arrow:
                    return Instantiate(_arrowPrefab).GetComponent<IProjectile>();
                case ProjectileType.Fireball:
                    return Instantiate(_fireballPrefab).GetComponent<IProjectile>();
                case ProjectileType.Bullet:
                    return Instantiate(_bulletPrefab).GetComponent<IProjectile>();
                default:
                    throw new NotImplementedException($"Projectile type {type} is not implemented");
            }
        }
    }
}

