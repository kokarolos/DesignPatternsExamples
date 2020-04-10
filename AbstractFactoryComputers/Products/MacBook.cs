using static AbstractFactoryComputers.AbstractProducts.Enumerations;

namespace AbstractFactoryComputers.Products
{
    public class MacBook : IProduct
    {
        public string GetBrand() => Brands.Apple.ToString();

        public string GetProcessor() => Processors.i5.ToString();

        public string GetSystemType() => ComputerTypes.Laptop.ToString();
    }
}
