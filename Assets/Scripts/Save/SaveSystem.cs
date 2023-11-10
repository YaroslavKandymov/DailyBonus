using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Bonus.Save
{
    public static class SaveSystem
    {
        private const string FileName = "/SaveData.fun";

        public static void SaveData(SaveData saveData)
        {
            string path = Application.persistentDataPath + FileName;

            using var stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, saveData);
        }

        public static SaveData LoadData()
        {
            string path = Application.persistentDataPath + FileName;

            bool fileExist = File.Exists(path);

            if (fileExist == false)
                return null;

            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();

            SaveData deserialized = (SaveData) formatter.Deserialize(stream);

            stream.Close();

            return deserialized;
        }

        public static void DeleteFile()
        {
            string path = Application.persistentDataPath + FileName;

            bool fileExist = File.Exists(path);

            if (fileExist)
            {
                File.Delete(path);
            }
        }
    }
}