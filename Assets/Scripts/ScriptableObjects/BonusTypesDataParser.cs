using System;
using System.Linq;
using Bonus.Enums;
using UnityEngine;

namespace Bonus.ScriptableObjects
{
    [CreateAssetMenu(fileName = "new BonusTypesDataParser", menuName = "StaticData/BonusTypesDataParser", order = 3)]
    public class BonusTypesDataParser : ScriptableObject
    {
        [SerializeField] private BonusNames[] _names;

        public BonusModeTypes GetType(string bonusName)
        {
            return _names.FirstOrDefault(b => b.Name == bonusName)!.ModeType;
        }
    }

    [Serializable]
    public class BonusNames
    {
        [SerializeField] private BonusModeTypes _modeType;
        [SerializeField] private string _name;

        public BonusModeTypes ModeType => _modeType;
        public string Name => _name;
    }
}