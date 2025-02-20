using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new ArgumentException();
                }
                else
                {
                    _name = value;
                }
            }
        }


        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    _species = value;
                }
            }
        }

        /// <summary>
        /// Abstract method with no implmetaion
        /// </summary>
        public abstract void MakeSound();
    }
}
