using System;
using AbstractFactoryComputers.Products;

namespace AbstractFactoryComputers.Factories
{
    public class MacFactory : ComputerFactory
    {
        public override IProduct GenerateProduct(string product)
        {
            switch (product)
            {
                case "desktop":
                    return new IMac();
                case "laptop":
                    return new MacBook();
                default:
                    throw new Exception("Product cannot be recognized");
            }
        }
    }
}
