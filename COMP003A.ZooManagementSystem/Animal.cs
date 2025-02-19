using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.ZooManagementSystem
{
    internal abstract class Animal
    {
        private string _name;
        private string _species;

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

        public abstract void MakeSound();
    }
}
