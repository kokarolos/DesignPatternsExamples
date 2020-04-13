namespace Eshop
{
    public abstract class PaymentMethod
    {
        public abstract void Pay(IProduct product);
    }
}
