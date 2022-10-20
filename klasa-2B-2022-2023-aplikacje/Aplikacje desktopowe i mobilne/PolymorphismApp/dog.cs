using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class dog
    {
        private string name;
        private byte age;

        public dog()
        {
            name = "Azor";
            age = 10;
        }

        public dog(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }

        public dog(dog dogToCopy)
        {
            name = dogToCopy.name;
            age = dogToCopy.age;
        }
        public void ShowInfo()
        {
            Console.WriteLine("******************");
            Console.WriteLine("Pies o imieniu" + name + "ma" + age + "lat");
            Console.WriteLine("******************");
        }

        public void Bark()
        {
            Console.WriteLine("Pies o imieniu" + name + "szczeka");
        }

        public void ChasePostman()
        {
            Console.WriteLine("pies o imieniu " + age + "goni listonosza");
        }               
    }
}