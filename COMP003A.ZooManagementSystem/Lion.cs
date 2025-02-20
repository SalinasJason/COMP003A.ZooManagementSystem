using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP003A.ZooManagementSystem;

namespace COMP003A.ZooManagementSystem
{
    /// <summary>
    /// Represents a Lion that inherits from Animal
    /// </summary>
    internal class Lion : Animal
    {
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="LionName"></param>
        /// <param name="LionSpecies"></param>
        public Lion (string LionName, string LionSpecies) 
        {
            Name = LionName;
            Species = LionSpecies;
        }

        /// <summary>
        /// Overrdies the MakeSound method
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"The lion roars! ({Name}, {Species})");
        }
    }
}