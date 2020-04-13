using AbstractFactoryComputers.Factories;
using AbstractFactoryComputers.Products;

namespace AbstractFactoryComputers
{
    public class Client
    {
        private IProduct _product;
        private ComputerFactory factory;
        public Client(string factoryInput,string productInput)
        {
            if (factoryInput == "dell")
            {
                factory = new DellFactory();
            }
            else
            {
                factory = new MacFactory();
            }
            _product = factory.GenerateProduct(productInput);
        }


        public string GetProductDescirption()
        {
            return $"Your Product is an {_product.GetBrand()} {_product.GetSystemType()} with {_product.GetProcessor()} processor";
        }
        
    }
}
