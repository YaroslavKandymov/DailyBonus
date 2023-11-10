using System.IO;
using UnityEngine;

namespace Bonus.Json
{
    public class JsonReader
    {
        public BonusMode LoadFile(string fileName)
        {
            return JsonUtility.FromJson<BonusMode>(File.ReadAllText(Application.streamingAssetsPath + "/" + fileName + ".json"));
        }
    }
}