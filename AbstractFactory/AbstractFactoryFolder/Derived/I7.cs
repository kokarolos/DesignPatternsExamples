using static AbstractFactory.Enumerations;

namespace AbstractFactory.AbstractFactoryFolder
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i7.ToString();
        }
    }
}
