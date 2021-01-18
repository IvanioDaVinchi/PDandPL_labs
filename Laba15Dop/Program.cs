using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Laba15Dop
{
    class Program
    {
        static void Serializ(List<Slave> list)
        {
            using (var fs = new FileStream($"{Directory.GetCurrentDirectory()}\\slaveFile.json", FileMode.OpenOrCreate))
            {
                var serializer = new DataContractJsonSerializer(typeof(List<Slave>));
                serializer.WriteObject(fs, list);
            }
        }
        static List<Slave> Deserializ()
        {
            List<Slave> list = new List<Slave>();
            using (var fs = new FileStream($"{Directory.GetCurrentDirectory()}\\slaveFile.json", FileMode.OpenOrCreate))
            {
                var serializer = new DataContractJsonSerializer(typeof(List<Slave>));
                list = serializer.ReadObject(fs)as List<Slave>;
            }
            return list;
        }
        static void Main(string[] args)
        {
            List<Shop> shops = new List<Shop>();
            List<Slave> list = new List<Slave>();
            list.Add(new Slave("Vlad", "112233"));
            list.Add(new Slave("Inokentii", "212233"));
            list.Add(new Slave("Vitaliy", "312233"));
            list.Add(new Slave("Afanasiy", "412233"));
            Serializ(list);
            Console.ReadLine();
        }
    }
}
