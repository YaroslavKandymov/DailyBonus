using Bonus.ScriptableObjects;
using UnityEngine;

namespace Bonus.BonusComponents
{
    public class BonusContainer : MonoBehaviour
    {
        [SerializeField] private BonusesCollection _bonusesCollection;

        private BonusData _bonusData;

        public void Init()
        {
            _bonusData = _bonusesCollection.GetRandomBonus();
        }
        
        public void Init(string id)
        {
            _bonusData = _bonusesCollection.GetBonus(id);
        }

        public BonusData GetTargetData()
        {
            return _bonusData;
        }
    }
}