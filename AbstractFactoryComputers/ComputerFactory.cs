using AbstractFactoryComputers.Products;

namespace AbstractFactoryComputers
{
    public abstract class ComputerFactory 
    {
        public abstract IProduct GenerateProduct(string product);

    }
}
