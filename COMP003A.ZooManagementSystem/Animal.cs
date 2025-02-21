using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace COMP003A.ZooManagementSystem
{
    /// <summary>
    /// Represents a base class for animals
    /// </summary>
    internal abstract class Animal
    {
        // Fields
        private string _name;
        private string _species;

        // Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Error: Name cannot be empty. Please provide a valid name.");
                    throw new ArgumentException();
                }
                _name = value;
                
            }
        }


        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error: Species cannot be empty. Please provide a valid species.");
                    throw new ArgumentException();
                }
                _species = value;
            }
        }

        /// <summary>
        /// Abstract method with no implmetaion
        /// </summary>
        public abstract void MakeSound();
    }
}
