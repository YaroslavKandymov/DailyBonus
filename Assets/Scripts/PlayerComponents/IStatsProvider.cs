using Bonus.ScriptableObjects;

namespace Bonus.PlayerComponents
{
    public interface IStatsProvider : IGameElement
    {
        public void GetBonus(BonusData bonusData);
    }
}