using AbstractFactoryNew.AbstractProducts;
using AbstractFactoryNew.Products;

namespace AbstractFactoryNew.Factories
{
    public class ElegantClothFactory :ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new SuitTrousers();
        }
    }
}
