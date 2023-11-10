using Bonus.Enums;
using Bonus.Json;
using Bonus.ScriptableObjects;
using UnityEngine;

namespace Bonus.BonusComponents
{
    public class BonusParser : MonoBehaviour
    {
        [SerializeField] private FileNameData _fileNameData;
        [SerializeField] private BonusTypesDataParser _bonusTypesDataParser;
        
        public BonusModeTypes GetBonusModeType()
        {
            var jsonReader = new JsonReader();
            BonusMode data = jsonReader.LoadFile(_fileNameData.Name);
            
            return _bonusTypesDataParser.GetType(data.DailyBonusType);
        }
    }
}