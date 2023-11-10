using Bonus.Enums;
using Bonus.Time;
using UnityEngine;

namespace Bonus.UI
{
    public class TimerAdapter : MonoBehaviour
    {
        private const int SecondsPerHour = 3600;
        private const int SecondsPerMinute = 60;

        [SerializeField] private TimerView _view;

        private Timer _timer;
        private BonusModeTypes _bonusModeType;

        public void Init(Timer timer, BonusModeTypes bonusModeType)
        {
            _timer = timer;
            _bonusModeType = bonusModeType;
            
            _timer.TimeChanged += OnTimeChanged;
        }

        private void OnDestroy()
        {
            _timer.TimeChanged -= OnTimeChanged;
        }

        private void OnTimeChanged()
        {
            ShowTime();
        }

        private void ShowTime()
        {
            if (_bonusModeType == BonusModeTypes.Test)
            {
                if (_timer.Time < SecondsPerHour)
                {
                    int minutes = Mathf.FloorToInt(_timer.Time / SecondsPerMinute);
                    int seconds = Mathf.FloorToInt(_timer.Time % SecondsPerMinute);

                    if (minutes < 0)
                    {
                        minutes = 0;
                    }
                    
                    if (seconds < 0)
                    {
                        seconds = 0;
                    }
                    
                    _view.SetText(minutes, seconds);
                }
                else
                {
                    int hours = Mathf.FloorToInt(_timer.Time / SecondsPerHour);
                    int minutes = Mathf.FloorToInt((_timer.Time % SecondsPerHour) / SecondsPerMinute);

                    _view.SetText(hours, minutes);
                }
            }
            else if(_bonusModeType == BonusModeTypes.Release)
            {
                //TODO:В задании не указан формат для этого вывода
            }
        }
    }
}