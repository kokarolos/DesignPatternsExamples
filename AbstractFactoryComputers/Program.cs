using System;
using AbstractFactoryComputers.Factories;

namespace AbstractFactoryComputers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your prefer Dell or Mac Factory?");
            var factoryInput = Console.ReadLine().ToLower().Trim();
            ComputerFactory factory = null;
            if(factoryInput == "dell")
            {
                factory = new DellFactory();
            }
            else
            {
                factory = new MacFactory();
            }
            Console.WriteLine("You prefer Desktop or Laptop?");
            var userInput = Console.ReadLine().ToLower().Trim();
            var client = new Client(factory, userInput);
            Console.WriteLine(client.GetProductDescirption());
        }
    }
}
