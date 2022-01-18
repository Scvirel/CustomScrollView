
using UnityEngine;
using UnityEngine.SceneManagement;

using Zenject;

namespace CustomScrollView
{
    //EnterPoint
    public class GameBootstrapper : MonoBehaviour
    {
        [Inject] private readonly ISceneLoader m_sceneLoader = default;
        [Inject] private readonly ISceneUnloader m_sceneUnloader = default;

        private void Start()
        {
            LoadGame();
        }

        private void LoadGame()
        {
            m_sceneLoader.LoadScene(GameScenes.CustomScrollView, LoadSceneMode.Single);
            m_sceneLoader.LoadScene(GameScenes.MainCamera, LoadSceneMode.Additive);
            m_sceneLoader.LoadScene(GameScenes.EventSystem, LoadSceneMode.Additive);

            m_sceneUnloader.UnloadScene(gameObject.scene);
        }
    }
}