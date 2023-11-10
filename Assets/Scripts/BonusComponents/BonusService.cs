using System;
using Bonus.Save;
using Bonus.Time;

namespace Bonus.BonusComponents
{
    public class BonusService : IDisposable
    {
        private readonly Timer _timer;
        private readonly BonusApplier _bonusApplier;
        private readonly SaveDataMediator _saveDataMediator;

        public BonusService(Timer timer, BonusApplier bonusApplier, SaveDataMediator saveDataMediator)
        {
            _bonusApplier = bonusApplier;
            _timer = timer;
            _saveDataMediator = saveDataMediator;

            _timer.Complete += OnTimerComplete;
        }

        private void OnTimerComplete()
        {
            _bonusApplier.GiveBonus();
            
            _saveDataMediator.Reset();
            
            _timer.Complete -= OnTimerComplete;
        }

        public void Dispose()
        {
            _timer.Complete -= OnTimerComplete;
        }
    }
}