
using Zenject;

namespace CustomScrollView
{
    public sealed class ItemFactoryInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesAndSelfTo<ItemFactory>()
                .FromInstance(new ItemFactory())
                .AsSingle();
        }
    }
}