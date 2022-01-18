
using Zenject;

namespace CustomScrollView
{
    public sealed class ItemsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<IItems>()
                .To<Items>()
                .FromInstance(new Items())
                .AsSingle();
        }
    }
}