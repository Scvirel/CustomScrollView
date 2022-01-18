using System;

using UnityEngine.SceneManagement;

using Zenject;

namespace CustomScrollView
{
    public interface ISceneLoader : IService
    {
        void LoadScene(string sceneName, LoadSceneMode mode);
        void LoadScene(string sceneName, LoadSceneMode mode, Action<DiContainer> container);
    }
}