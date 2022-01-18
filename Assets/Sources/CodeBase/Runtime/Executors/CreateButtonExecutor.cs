
using UnityEngine;
using UnityEngine.Assertions;

using Zenject;

namespace CustomScrollView
{
    public sealed class CreateButtonExecutor : ButtonExecutor
    {
        [Inject] private readonly IItemFactory m_itemFactory = default;
        [Inject] private readonly IItems m_items = default;

        [SerializeField] private Transform m_parent = default;
        [SerializeField] private int m_itemsCount = default;

        protected override void Execute()
        {
            for (int i = 0; i < m_itemsCount; i++)
            {
                CreateItem();
            }
        }

        private void CreateItem()
        {
            Item item = m_itemFactory.Create(m_parent);
            item.Init(m_items.Value.Count+1);

            m_items.Value.Push(item);
        }
    }
}