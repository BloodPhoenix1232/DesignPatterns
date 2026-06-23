using System;
using UnityEngine;
using Zenject;

namespace Combined 
{
    public class ProjectileFactory : MonoBehaviour
    {
        [Inject] private DiContainer _container;

        [SerializeField] private GameObject _arrowPrefab;
        [SerializeField] private GameObject _fireballPrefab;
        [SerializeField] private GameObject _bulletPrefab;

        public IProjectile Create(ProjectileType type)
        {
            switch (type)
            {
                case ProjectileType.Arrow:
                    return _container.InstantiatePrefab(_arrowPrefab).GetComponent<IProjectile>();
                case ProjectileType.Fireball:
                    return _container.InstantiatePrefab(_fireballPrefab).GetComponent<IProjectile>();
                case ProjectileType.Bullet:
                    return _container.InstantiatePrefab(_bulletPrefab).GetComponent<IProjectile>();
                default:
                    throw new NotImplementedException($"Projectile type {type} is not implemented");
            }
        }
    }
}

