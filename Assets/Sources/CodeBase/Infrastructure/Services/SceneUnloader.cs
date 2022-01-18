using UnityEngine.SceneManagement;

namespace CustomScrollView
{
    public sealed class SceneUnloader : ISceneUnloader
    {
        public void UnloadScene(string sceneName)
        {
            SceneManager.UnloadSceneAsync(sceneName);
        }

        public void UnloadScene(Scene sceneInstance)
        {
            SceneManager.UnloadSceneAsync(sceneInstance);
        }
    }
}