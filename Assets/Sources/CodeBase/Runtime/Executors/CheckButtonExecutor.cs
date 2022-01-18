using UnityEngine.SceneManagement;

using Zenject;

namespace CustomScrollView
{
    public sealed partial class CheckButtonExecutor : ButtonExecutor
    {
        [Inject] private readonly IItems m_items = default;
        [Inject] private readonly ISceneLoader m_sceneLoader = default;

        protected override void Execute()
        {
            Check();
        }

        private void Check()
        {
            ItemStatus status = default;

            foreach (Item item in m_items.Value)
            {
                if (item.IsSelected && (status == ItemStatus.Default || status == ItemStatus.All))
                {
                    status = ItemStatus.All;
                }
                else
                {
                    if (!item.IsSelected && (status == ItemStatus.Default || status == ItemStatus.None))
                    {
                        status = ItemStatus.None;
                    }
                    else
                    {
                        status = ItemStatus.Different;
                        break;
                    }
                }
            }

            ShowMessage(status);
        }

        private void ShowMessage(ItemStatus status)
        {
            ItemsStatus itemStatus = new ItemsStatus();
            itemStatus.Value = status;

            m_sceneLoader.LoadScene(
                GameScenes.MessagePopup,
                LoadSceneMode.Additive,
                container =>
                {
                    container
                        .Bind<IItemsStatus>()
                        .To<ItemsStatus>()
                        .FromInstance(itemStatus)
                        .AsSingle();
                });
        }
    }
}