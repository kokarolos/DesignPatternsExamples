using AbstractFactory;
using AbstractFactory.AbstractFactoryFolder;

public class DellLaptopFactory : DellFactory
{
    public override ISystemType SystemType()
    {
        return new Laptop();
    }
}