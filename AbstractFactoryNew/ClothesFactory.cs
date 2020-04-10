using AbstractFactoryNew.AbstractProducts;

namespace AbstractFactoryNew
{
    public abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();
    }
}
