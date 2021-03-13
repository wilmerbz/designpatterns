using AbstractFactory;
using BeforeFactory;
using FactoryMethod;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var option = string.Empty;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter an option: \n[1] - Before Factory. \n[2] - Simple Factory. \n[3] Factory Method. \n[4] Abstract Factory.\n[x] - Exit");
                option = Console.ReadLine();
                option = option.ToLower();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("- - - - - BEFORE FACTORY - - - - -");
                        ExampleBeforeFactory.RunClient();
                        break;
                    case "2":
                        Console.WriteLine("- - - - - SIMPLE FACTORY - - - - -");
                        ExampleSimpleFactory.RunClient();
                        break;
                    case "3":
                        Console.WriteLine("- - - - - FACTORY METHOD - - - - -");
                        ExampleFactoryMethod.RunClient();
                        break;
                    case "4":
                        Console.WriteLine("- - - - - ABSTRACT FACTORY - - - - -");
                        ExampleAbstractFactory.RunClient();
                        break;
                    case "x":
                        Console.WriteLine("Bye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Try again...");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
