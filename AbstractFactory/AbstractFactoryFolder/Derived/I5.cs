using static AbstractFactory.Enumerations;

namespace AbstractFactory.AbstractFactoryFolder
{
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i5.ToString();
        }
    }
}
