
using UnityEngine;

using Zenject;

namespace CustomScrollView
{
    public sealed class RemoveButtonExecutor : ButtonExecutor
    {
        [Inject] private readonly IItems m_items = default;

        protected override void Execute()
        {
            if (m_items.Value.Count > 0)
            {
                GameObject.Destroy(
                    m_items.Value.Pop()
                    .gameObject
                    );
            }
        }
    }
}