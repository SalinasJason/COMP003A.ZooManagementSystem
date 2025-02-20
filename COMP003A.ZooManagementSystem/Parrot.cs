using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem
{
    /// <summary>
    /// Represents a parrot that inherits from Animal
    /// </summary>
    internal class Parrot : Animal
    {
        /// <summary>
        /// Contrustor
        /// </summary>
        /// <param name="ParrotName"></param>
        /// <param name="ParrotSpecies"></param>
        public Parrot(string ParrotName, string ParrotSpecies)
        {
            Name = ParrotName;
            Species = ParrotSpecies;
        }

        /// <summary>
        /// Overrides the MakeSound method
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"The parrot squawks! ({Name}, {Species})");
        }
    }
}
