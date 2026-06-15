using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectileLauncher : MonoBehaviour
{
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
            var iceBolt = _factory.Create(ProjectileType.IceBolt);
            iceBolt.Shoot();
        }
    }
}
