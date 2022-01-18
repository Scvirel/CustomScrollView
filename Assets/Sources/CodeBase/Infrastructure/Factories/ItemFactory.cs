using UnityEngine;

namespace CustomScrollView
{
    public sealed class ItemFactory : IItemFactory
    {
        private Pool m_pool = default;

        public ItemFactory()
        {
            m_pool = new Pool();
        }

        Item IFactory<Item>.Create(Transform parent)
        {
            GameObject obj = m_pool.Create(GamePrefabs.ItemPrefab, parent);
            return obj.GetComponent<Item>();
        }
    }
}