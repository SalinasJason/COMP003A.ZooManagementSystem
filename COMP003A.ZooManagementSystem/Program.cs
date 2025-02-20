// Author: Jason Salinas
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and method overloading in C#
namespace COMP003A.ZooManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Zoo Management System!");
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1. Add a Lion");
            Console.WriteLine("2. Add a Parrot");
            Console.WriteLine("3. Display All Animals");
            Console.WriteLine("4. Describe an Aniaml");
            Console.WriteLine("5. Exit");

            int choice = 0;
            Console.Write("\nYour choice: ");
            choice = int.Parse(Console.ReadLine()); 
        }
    }
}
