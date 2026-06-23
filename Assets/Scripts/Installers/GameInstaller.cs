using Zenject;
using Combined;


public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Combined.GameManager>().FromComponentInHierarchy().AsSingle();
        Container.Bind<Combined.ProjectileFactory>().FromComponentInHierarchy().AsSingle();
    }
}
