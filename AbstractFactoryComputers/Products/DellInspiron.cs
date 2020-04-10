using static AbstractFactoryComputers.AbstractProducts.Enumerations;

namespace AbstractFactoryComputers.Products
{
    public class DellInspiron : IProduct
    {
        public string GetBrand() => Brands.Dell.ToString();

        public string GetProcessor() => Processors.i7.ToString();

        public string GetSystemType() => ComputerTypes.Laptop.ToString();
    }
}
