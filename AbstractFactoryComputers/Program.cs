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
            Console.WriteLine("You prefer Desktop or Laptop?");
            var userInput = Console.ReadLine().ToLower().Trim();
            var client = new Client(factoryInput, userInput);
            Console.WriteLine(client.GetProductDescirption());
        }
    }
}
