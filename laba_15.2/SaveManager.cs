using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace laba_15._2
{
    public class SaveManager
    {
        public void Save(Game objectGame)
        {
            using (var fs = new FileStream($"{Directory.GetCurrentDirectory()}\\saveGameFeodal.json", FileMode.OpenOrCreate))
            {
                var serializer = new DataContractJsonSerializer(typeof(Game));
                serializer.WriteObject(fs, objectGame);
            }
        }
        public Game Load()
        {
            Game objectGame;
            using (var fs = new FileStream($"{Directory.GetCurrentDirectory()}\\saveGameFeodal.json", FileMode.OpenOrCreate))
            {
                var serializer = new DataContractJsonSerializer(typeof(Game));
                objectGame = (Game)serializer.ReadObject(fs);
            }
            return objectGame;
        }
        public void BinarySave(Game objectGame)
        {
            using (var fs = new FileStream($"{Directory.GetCurrentDirectory()}\\saveGameFeodal.bin", FileMode.OpenOrCreate))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(fs, objectGame);
            }
        }
        public Game BinaryLoad()
        {
            using (var fs = new FileStream($"{Directory.GetCurrentDirectory()}\\saveGameFeodal.bin", FileMode.OpenOrCreate))
            {
                var serializer = new BinaryFormatter();
                return (Game)serializer.Deserialize(fs);
            }
        }
    }
}
