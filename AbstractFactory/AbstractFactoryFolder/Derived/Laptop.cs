using static AbstractFactory.Enumerations;

namespace AbstractFactory.AbstractFactoryFolder
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
}
