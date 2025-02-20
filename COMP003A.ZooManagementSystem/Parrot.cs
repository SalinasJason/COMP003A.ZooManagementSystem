using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem
{
    internal class Parrot : Animal
    {
        public Parrot(string ParrotName, string ParrotSpecies)
        {
            Name = ParrotName;
            Species = ParrotSpecies;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The parrot squawks! ({Name}, {Species})");
        }
    }
}
