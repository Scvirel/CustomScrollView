using ModestTree;

using System;
using System.Threading;
using System.Threading.Tasks;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

namespace CustomScrollView
{
    public sealed class Item : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI m_numberText = default;
        [SerializeField] private Toggle m_checkToggle = default;

        public bool IsSelected { get; private set; }

        private void Awake()
        {
            Assert.IsNotNull(m_numberText);
            Assert.IsNotNull(m_checkToggle);

            m_checkToggle.onValueChanged.AddListener(SelectionChange);
        }

        public void Init(int number)
        {
            m_numberText.text = number.ToString();
            m_checkToggle.isOn = false;
        }

        private void SelectionChange(bool value)
        {
            IsSelected = value;
            SelectionChangeRequest(value);
        }

        private async void SelectionChangeRequest(bool value)
        {
            await Task.Run(
                delegate {
                    Debug.Log($"Sending selection request with value : {value}");
                    Thread.Sleep(1000);
                    Debug.Log("Selection request sended");
                    }
                );
        }
    }
}