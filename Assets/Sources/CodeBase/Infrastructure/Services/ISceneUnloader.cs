using UnityEngine.SceneManagement;

namespace CustomScrollView
{
    public interface ISceneUnloader : IService
    {
        void UnloadScene(string sceneName);
        void UnloadScene(Scene sceneInstance);
    }
}