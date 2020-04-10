using static AbstractFactoryComputers.AbstractProducts.Enumerations;

namespace AbstractFactoryComputers.Products
{
    public class DellOptiplex : IProduct
    {
        public string GetBrand() => Brands.Dell.ToString();

        public string GetProcessor() => Processors.i5.ToString();

        public string GetSystemType() => ComputerTypes.Desktop.ToString();
    }
}
