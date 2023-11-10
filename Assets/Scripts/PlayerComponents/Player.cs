using System;
using UnityEngine;

namespace Bonus.PlayerComponents
{
    public class Player : MonoBehaviour
    {
        private IGameElement[] _gameElements;
        
        private void Awake()
        {
            _gameElements = GetComponentsInChildren<IGameElement>();
        }

        public T Get<T>()
        {
            for (int i = 0, count = _gameElements.Length; i < count; i++)
            {
                if (_gameElements[i] is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Element of type {typeof(T).Name} is not found!");
        }
    }
}