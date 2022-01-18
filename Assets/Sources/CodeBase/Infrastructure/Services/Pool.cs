
using System.Collections.Generic;

using UnityEngine;

namespace CustomScrollView
{
    public sealed class Pool : IPool
    {
        private int m_createdCount = default;
        private int m_capacity = 5;

        private Queue<GameObject> m_pooledObjects = new Queue<GameObject>();

        public GameObject Create(string prefabPath, Transform parent)
        {
            if (m_createdCount >= m_capacity || m_createdCount == 0)
            {
                CreateWithCapacity(prefabPath);
                m_createdCount = 0;
            }

            m_createdCount++;

            m_pooledObjects
                .Peek()
                .transform
                .SetParent(parent);

            return m_pooledObjects.Dequeue();
        }

        public void CreateWithCapacity(string prefabPath)
        {
            for (int i = 0; i < m_capacity; i++)
            {
                m_pooledObjects.Enqueue(
                    GameObject.Instantiate(Resources.Load<GameObject>(prefabPath)));
            }
        }
    }
}