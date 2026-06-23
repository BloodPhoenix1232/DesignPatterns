using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Combined 
{
    public class ProjectileLauncher : MonoBehaviour
    {
        [Inject] private GameManager _gameManager;

        [SerializeField] private ProjectileFactory _factory;

        void Update()
        {
            if (Keyboard.current.digit1Key.wasPressedThisFrame)
            {
                var arrow = _factory.Create(ProjectileType.Arrow);
                arrow.Shoot();
            }

            if (Keyboard.current.digit2Key.wasPressedThisFrame)
            {
                var fireball = _factory.Create(ProjectileType.Fireball);
                fireball.Shoot();
            }

            if (Keyboard.current.digit3Key.wasPressedThisFrame)
            {
                var iceBolt = _factory.Create(ProjectileType.Bullet);
                iceBolt.Shoot();
            }

            if (Keyboard.current.zKey.wasPressedThisFrame)
            {
                _gameManager.Undo();
            }
        }
    }
}

