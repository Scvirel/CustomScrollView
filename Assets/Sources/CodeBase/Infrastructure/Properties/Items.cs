
using System.Collections.Generic;

namespace CustomScrollView
{
    public sealed class Items : IItems
    {
        private Stack<Item> m_items = new Stack<Item>();
        Stack<Item> IProperty<Stack<Item>>.Value 
        { 
            get => m_items;
            set => m_items = value;
        }
    }
}