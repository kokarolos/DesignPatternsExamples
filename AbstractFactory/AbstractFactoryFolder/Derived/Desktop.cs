using static AbstractFactory.Enumerations;

namespace AbstractFactory.AbstractFactoryFolder
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}
