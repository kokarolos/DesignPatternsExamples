namespace AbstractFactory.AbstractFactoryFolder
{
    interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
