namespace Bonus.Save
{
    public class SaveDataMediator
    {
        private SaveData _saveData;

        public SaveDataMediator()
        {
            _saveData = SaveSystem.LoadData();
        }

        public SaveData GetData()
        {
            return _saveData;
        }

        public void CreateData(string id)
        {
            if (_saveData == null)
            {
                _saveData = new SaveData
                {
                    Id = id
                };

                SaveSystem.SaveData(_saveData);
            }
        }

        public void ChangeTime(float time)
        {
            if(_saveData == null)
                return;
            
            _saveData.RemainingTime = time;

            SaveSystem.SaveData(_saveData);
        }

        public void Reset()
        {
            _saveData = null;
            
            SaveSystem.DeleteFile();
        }
    }
}