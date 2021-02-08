using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithLinqAndXML
{
    public class Dog
    {
        public string name;
        public string breed;
        public string age;
        public string placeLiving;
        public string nameOrner;

        public Dog(string name, string breed, string age, string placeLiving, string nameOrner)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.placeLiving = placeLiving;
            this.nameOrner = nameOrner;
        }
        public Dog()
        {

        }
    }
}
