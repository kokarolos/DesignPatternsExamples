using AbstractFactoryNew.AbstractProducts;
using AbstractFactoryNew.Products;

namespace AbstractFactoryNew.Factories
{
    public class CasualClothFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
