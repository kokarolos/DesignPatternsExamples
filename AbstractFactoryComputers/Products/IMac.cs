using static AbstractFactoryComputers.AbstractProducts.Enumerations;

namespace AbstractFactoryComputers.Products
{
    public class IMac : IProduct
    {
        public string GetBrand() => Brands.Apple.ToString();

        public string GetProcessor() => Processors.i7.ToString();

        public string GetSystemType() => ComputerTypes.Desktop.ToString();
    }
}
