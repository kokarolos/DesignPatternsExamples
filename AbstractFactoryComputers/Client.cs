using AbstractFactoryComputers.Factories;
using AbstractFactoryComputers.Products;

namespace AbstractFactoryComputers
{
    public class Client
    {
        private IProduct _product;
        public Client(ComputerFactory factory,string userInput)
        {
            _product = factory.GenerateProduct(userInput);
        }


        public string GetProductDescirption()
        {
            return $"Your Product is an {_product.GetBrand()} {_product.GetSystemType()} with {_product.GetProcessor()} processor";
        }
        
    }
}
