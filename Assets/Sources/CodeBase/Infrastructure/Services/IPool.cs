
using UnityEngine;

namespace CustomScrollView
{
    public interface IPool : IService
    {
        GameObject Create(string prefabPath,Transform parent);
    }
}