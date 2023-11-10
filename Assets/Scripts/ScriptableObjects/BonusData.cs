using Bonus.Enums;
using UnityEngine;

namespace Bonus.ScriptableObjects
{
    [CreateAssetMenu(fileName = "new BonusData", menuName = "StaticData/BonusData", order = 1)]
    public class BonusData : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private Sprite _avatarBonus;
        [SerializeField] private float _timeBonus;
        [SerializeField] private BonusTypes _bonusType;
        [SerializeField] private float _value;

        public string ID => _id;
        public Sprite AvatarBonus => _avatarBonus;
        public float TimeBonus => _timeBonus;
        public BonusTypes BonusType => _bonusType;
        public float Value => _value;

        private void OnValidate()
        {
            if (_timeBonus < 0)
            {
                _timeBonus = 0;
            }
        }
    }
}