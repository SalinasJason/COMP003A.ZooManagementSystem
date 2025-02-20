using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP003A.ZooManagementSystem;

namespace COMP003A.ZooManagementSystem
{
    /// <summary>
    /// A class that has method overloading
    /// </summary>
    internal class ZooUtility
    {
        /// <summary>
        /// Displays the name of a animal
        /// </summary>
        /// <param name="name"></param>
        public static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        /// <summary>
        /// Displays the name and species of a animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"Species: {species}");
        }

        /// <summary>
        /// Displays name, species, and age of a animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="species"></param>
        /// <param name="age"></param>
        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name, species);
            Console.WriteLine($"Age: {age}");
        }
    }
}