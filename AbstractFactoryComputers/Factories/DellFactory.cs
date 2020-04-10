using AbstractFactoryComputers.Products;
using System;

namespace AbstractFactoryComputers.Factories
{
    public class DellFactory : ComputerFactory
    {
        public override IProduct GenerateProduct(string product)
        {
            switch (product)
            {
                case "desktop":
                    return new DellOptiplex();
                case "laptop":
                    return new DellInspiron();
                default:
                    throw new Exception("Product cannot be recognized");
            }
        }
    }
}
