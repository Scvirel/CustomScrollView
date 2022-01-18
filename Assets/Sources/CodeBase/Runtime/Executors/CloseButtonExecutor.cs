
using Zenject;

namespace CustomScrollView
{
    public sealed class CloseButtonExecutor : ButtonExecutor
    {
        [Inject] private readonly ISceneUnloader m_sceneUnloader = default;

        protected override void Execute()
        {
            m_sceneUnloader.UnloadScene(gameObject.scene);
        }
    }
}