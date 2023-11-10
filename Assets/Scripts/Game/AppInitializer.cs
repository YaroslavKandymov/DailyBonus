using Bonus.BonusComponents;
using Bonus.PlayerComponents;
using Bonus.Save;
using Bonus.Time;
using Bonus.UI;
using UnityEngine;

namespace Bonus.Game
{
    public class AppInitializer : MonoBehaviour
    {
        [SerializeField] private BonusParser _bonusParser;
        [SerializeField] private BonusContainer _bonusContainer;
        [SerializeField] private TimerAdapter _timerAdapter;
        [SerializeField] private Player _player;
        
        private Timer _timer;
        private SaveDataMediator _saveDataMediator;
        private float _remainingTime;

        private void Start()
        {
            Prepare();
            StartWork();
        }

        private void OnDestroy()
        {
            _timer.StopCount();
            
            _saveDataMediator.ChangeTime(_timer.Time);
        }

        private void Prepare()
        {
            _timer = new Timer(this);

            var currentBonusModeType = _bonusParser.GetBonusModeType();
            _saveDataMediator = new SaveDataMediator();
            var saveDataInitializer = new SaveDataInitializer(_saveDataMediator, _bonusContainer);

            _remainingTime = saveDataInitializer.RemainingTime;

            _timerAdapter.Init(_timer, currentBonusModeType);
            
            var bonusApplier = new BonusApplier(_player, _bonusContainer.GetTargetData());
            var bonusService = new BonusService(_timer, bonusApplier, _saveDataMediator);
        }
        
        private void StartWork()
        {
            _timer.StartCount(_remainingTime);
        }
    }
}