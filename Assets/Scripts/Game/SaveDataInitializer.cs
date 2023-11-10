using Bonus.BonusComponents;
using Bonus.Save;

namespace Bonus.Game
{
    public class SaveDataInitializer
    {
        private readonly SaveDataMediator _saveDataMediator;
        private readonly BonusContainer _bonusContainer;

        public float RemainingTime { get; private set; }

        public SaveDataInitializer(SaveDataMediator saveDataMediator, BonusContainer bonusContainer)
        {
            _saveDataMediator = saveDataMediator;
            _bonusContainer = bonusContainer;
            
            Initialize();
        }

        private void Initialize()
        {
            var saveData = _saveDataMediator.GetData();

            if (saveData == null)
            {
                _bonusContainer.Init();

                _saveDataMediator.CreateData(_bonusContainer.GetTargetData().ID);

                RemainingTime = _bonusContainer.GetTargetData().TimeBonus;
            }
            else
            {
                _bonusContainer.Init(saveData.Id);

                RemainingTime = saveData.RemainingTime;
            }
        }
    }
}