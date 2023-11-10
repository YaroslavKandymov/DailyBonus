using System;
using System.Collections;
using UnityEngine;

namespace Bonus.Time
{
    public class Timer
    {
        private readonly MonoBehaviour _monoBehaviour;
        private Coroutine _coroutine;
        
        public float Time { get; private set; }

        public event Action TimeChanged;
        public event Action Complete;

        public Timer(MonoBehaviour monoBehaviour)
        {
            _monoBehaviour = monoBehaviour;
        }

        public void StartCount(float maxTime)
        {
            Time = maxTime;
            
            _coroutine = _monoBehaviour.StartCoroutine(MoveTime());
        }

        public void StopCount()
        {
            if (_coroutine != null)
            {
                _monoBehaviour.StopCoroutine(_coroutine);
            }
        }

        private IEnumerator MoveTime()
        {
            while (Time > 0)
            {
                Time -= UnityEngine.Time.deltaTime;

                TimeChanged?.Invoke();

                yield return null;
            }
            
            Complete?.Invoke();
        }
    }
}