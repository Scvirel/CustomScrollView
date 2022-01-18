namespace CustomScrollView
{
    public sealed class ItemsStatus : IItemsStatus
    {
        private ItemStatus m_value = default;

        public ItemStatus Value 
        { 
            get => m_value;
            set => m_value = value;
        }
    }
}