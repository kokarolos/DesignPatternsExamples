using AbstractFactory;
using AbstractFactory.AbstractFactoryFolder;
public class MacLaptopFactory : MacFactory
{
    public override ISystemType SystemType()
    {
        return new Laptop();
    }
}
 
