using TMPro;
using UnityEngine;

namespace Bonus.UI
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        public void SetText(float leftValue, float rightValue)
        {
            _text.text = $"{leftValue:00}:{rightValue:00}";
        }
    }
}