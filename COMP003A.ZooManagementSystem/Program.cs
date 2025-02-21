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
            List<Animal> animal = new List<Animal>();
            int choice = 0;

            Console.WriteLine("Welcome to the Zoo Management System!");
            do
            {
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Add a Lion");
                Console.WriteLine("2. Add a Parrot");
                Console.WriteLine("3. Display All Animals");
                Console.WriteLine("4. Describe an Aniaml");
                Console.WriteLine("5. Exit");

                Console.Write("\nYour choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Add a lion
                        Console.Write("Enter the name of the lion: ");
                        string UserInputLionName = Console.ReadLine();

                        Console.Write("Enter the species of the lion: ");
                        string UserInputLionSpecies = Console.ReadLine();

                        Lion lion = new Lion(UserInputLionName, UserInputLionSpecies);
                        animal.Add(lion);


                        break;
                    case 2: // Add a parrot
                        Console.Write("Enter the name of the parrot: ");
                        string UserInputParrotName = Console.ReadLine();

                        Console.Write("Enter the species of the parrot: ");
                        string UserInputParrotSpecies = Console.ReadLine();

                        Parrot parrot = new Parrot(UserInputParrotName, UserInputParrotSpecies);
                        animal.Add(parrot);

                        break;
                    case 3: // Displays all animals
                        Console.WriteLine("Displaying all animals: ");
                        foreach (Animal animals in animal)
                        {
                            animals.MakeSound();
                        }
                        break;
                    case 4: // Describes an animal
                        Console.WriteLine();
                        break;
                    case 5: // Exit
                        Console.WriteLine();
                        break;
                    default:
                        break;

                }

            }   while (choice != 5);


        }
    }
}
