using UnityEngine;

namespace Bonus.ScriptableObjects
{
    [CreateAssetMenu(fileName = "new FileNameData", menuName = "StaticData/FileNameData", order = 2)]
    public class FileNameData : ScriptableObject
    {
        [SerializeField] private string _name;

        public string Name => _name;
    }
}