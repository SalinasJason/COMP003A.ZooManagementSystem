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
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Invaild input, please input valid number (1-5)");
                }

                switch (choice)
                {
                    case 1: // Add a lion
                        Console.Write("Enter the name of the lion: ");
                        string UserInputLionName = Console.ReadLine();

                        Console.Write("Enter the species of the lion: ");
                        string UserInputLionSpecies = Console.ReadLine();

                        try
                        {
                            Lion lion = new Lion(UserInputLionName, UserInputLionSpecies);
                            animal.Add(lion);
                            Console.WriteLine("Lion added successfully!");
                        }
                        catch
                        {
                            Console.WriteLine("Error: Name or Species is empty. Please provide a vaild name or species.");
                        }


                        break;
                    case 2: // Add a parrot
                        Console.Write("Enter the name of the parrot: ");
                        string UserInputParrotName = Console.ReadLine();

                        Console.Write("Enter the species of the parrot: ");
                        string UserInputParrotSpecies = Console.ReadLine();

                        try
                        {
                            Parrot parrot = new Parrot(UserInputParrotName, UserInputParrotSpecies);
                            animal.Add(parrot);
                            Console.WriteLine("Parrot added successfully!");
                        }
                        catch
                        {
                            Console.WriteLine("Error: Name or Species is empty. Please provide a vaild name or species.");
                        }

                        break;
                    case 3: // Displays all animals
                        Console.WriteLine("Displaying all animals: ");
                        foreach (Animal animals in animal)
                        {
                            animals.MakeSound();
                        }
                        break;
                    case 4: // Describes an animal
                        ZooUtility.DescribeAnimal("Simba");
                        ZooUtility.DescribeAnimal("Polly", "Psittaciformes");
                        ZooUtility.DescribeAnimal("Charlie", "Elephant", 21);
                        break;
                    case 5: // Exit
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invaild input, Please choose from (1-5)");
                        break;

                }

            }   while (choice != 5);


        }
    }
}
