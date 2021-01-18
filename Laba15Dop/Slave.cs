using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Laba15Dop
{
    [DataContract]
    public class Slave
    {
        [DataMember]
        public string slaveName;
        [DataMember]
        public string slaveNumber;
        [DataMember]
        public const int slaveCost = 300;

        public Slave(string name, string number)
        {
            slaveName = name;
            slaveNumber = number;
        }
    }
}
