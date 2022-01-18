
using UnityEngine;

using Zenject;

namespace CustomScrollView
{
    public sealed class ShowMessageExecutor : BaseExecutor
    {
        [Inject] private readonly IItemsStatus m_itemStatus = default;

        [SerializeField] private GameObject m_all = default;
        [SerializeField] private GameObject m_different = default;
        [SerializeField] private GameObject m_none = default;

        private void Awake()
        {
            Execute();
        }

        protected override void Execute()
        {
            switch (m_itemStatus.Value)
            {
                case ItemStatus.All:
                    m_all.SetActive(true);
                    break;
                case ItemStatus.Different:
                    m_different.SetActive(true);
                    break;
                case ItemStatus.None:
                    m_none.SetActive(true);
                    break;
            }
        }

    }
}