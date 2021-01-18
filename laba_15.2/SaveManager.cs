using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace laba_15._2
{
    public class SaveManager
    {
        
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
