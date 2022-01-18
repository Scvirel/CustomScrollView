
using Zenject;

namespace CustomScrollView
{
    public sealed class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesAndSelfTo<SceneLoader>()
                .AsSingle();
            Container
                .BindInterfacesAndSelfTo<SceneUnloader>()
                .AsSingle();
        }
    }
}