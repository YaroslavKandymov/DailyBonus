using Bonus.PlayerComponents;
using Bonus.ScriptableObjects;

namespace Bonus.BonusComponents
{
    public class BonusApplier
    {
        private readonly Player _player;
        private readonly BonusData _bonusData;

        public BonusApplier(Player player, BonusData bonusData)
        {
            _player = player;
            _bonusData = bonusData;
        }

        public void GiveBonus()
        {
            _player.Get<IStatsProvider>().GetBonus(_bonusData);
        }
    }
}