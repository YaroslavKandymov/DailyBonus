using System;
using Bonus.Enums;
using Bonus.ScriptableObjects;
using UnityEngine;

namespace Bonus.PlayerComponents
{
    public class PlayerStatsChanger : MonoBehaviour, IStatsProvider
    {
        public void GetBonus(BonusData bonusData)
        {
            switch (bonusData.BonusType)
            {
                case BonusTypes.Experience:
                    break;
                case BonusTypes.Health:
                    break;
                case BonusTypes.Mana:
                    break;
                default:
                    throw new ArgumentException("Wrong data");
            }
        }
    }
}