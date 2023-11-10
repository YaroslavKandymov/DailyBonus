using System.Linq;
using UnityEngine;

namespace Bonus.ScriptableObjects
{
    [CreateAssetMenu(fileName = "new BonusesCollection", menuName = "StaticData/BonusesCollection", order = 4)]
    public class BonusesCollection : ScriptableObject
    {
        [SerializeField] private BonusData[] _bonusDatas;

        public BonusData GetBonus(string id)
        {
            return _bonusDatas.FirstOrDefault(b => b.ID == id);
        }
        
        public BonusData GetRandomBonus()
        {
            return _bonusDatas.ElementAt(Random.Range(0, _bonusDatas.Length));
        }
    }
}