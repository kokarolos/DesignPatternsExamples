using AbstractFactory.AbstractFactoryFolder;
using System;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Type The Computer Brand you prefer");
            var userInput = Console.ReadLine().Trim().ToLower();
            var computer = Client(userInput);
            Console.WriteLine($"The Computer you got is {computer.Brand().GetBrand()} with {computer.Processor().GetProcessor()}" +
                $" processor and it is of type {computer.SystemType().GetSystemType()}");
            
        }

        public static IComputerFactory Client(string userInput)
        {
            switch (userInput)
            {
                case "dell":
                    return new DellFactory();
                case "delllaptop":
                    return new DellLaptopFactory();
                case "Mac":
                    return new MacFactory();
                case "maclaptop":
                    return new MacLaptopFactory();
                default:
                    return new DellFactory();
            }
        }
    }
}
