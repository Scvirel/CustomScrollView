using System;

using UnityEngine.SceneManagement;

using Zenject;

namespace CustomScrollView
{
    public sealed class SceneLoader : ISceneLoader
    {
        [Inject] private ZenjectSceneLoader m_sceneLoader = default;

        public void LoadScene(string sceneName, LoadSceneMode mode)
        {
            SceneManager.LoadSceneAsync(sceneName, mode);
        }

        public void LoadScene(string sceneName, LoadSceneMode mode, Action<DiContainer> container)
        {
            m_sceneLoader.LoadSceneAsync(sceneName, mode, container);
        }
    }
}