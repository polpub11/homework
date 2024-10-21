using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Welcome to the C# Console Application!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Data Types Display");
                Console.WriteLine("2. Basic Math Operations");
                Console.WriteLine("3. Conditional Statements");
                Console.WriteLine("4. Loop Demonstrations");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DataTypes dataTypes = new DataTypes();
                        dataTypes.Display();
                        break;

                    case 2:
                        BasicMath math = new BasicMath();
                        math.PerformOperations();
                        break;

                    case 3:
                        ConditionalStatements cond = new ConditionalStatements();
                        cond.CheckNumber();
                        break;

                    case 4:
                        Loops loops = new Loops();
                        loops.LoopDemo();
                        break;

                    case 5:
                        Console.WriteLine("Thank you for using the application. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();  // Adds a line break between menu displays
            } while (choice != 5);
        }
    }
}

