using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP003A.ZooManagementSystem;

namespace COMP003A.ZooManagementSystem
{
    internal class Lion : Animal
    {
        public Lion (string LionName, string LionSpecies) 
        {
            Name = LionName;
            Species = LionSpecies;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The lion roars! ({Name}, {Species})");
        }
    }
}