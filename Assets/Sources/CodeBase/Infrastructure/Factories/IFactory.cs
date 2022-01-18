
using UnityEngine;

namespace CustomScrollView
{
    public interface IFactory<ObjectType>
    {
        ObjectType Create(Transform parent);
    }
}