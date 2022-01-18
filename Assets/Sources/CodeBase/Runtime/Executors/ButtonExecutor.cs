using UnityEngine.UI;

namespace CustomScrollView
{
    public abstract class ButtonExecutor : BaseExecutor
    {
        public Button Target = default;

        protected virtual void Awake()
        {
            Target.onClick.AddListener(Execute);
        }
    }
}