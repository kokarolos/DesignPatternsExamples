using System;

namespace Eshop
{
    public class CreditCard:PaymentMethod
    {
        public override void Pay(IProduct product)
        {
            Console.WriteLine($"Succcessfuly purchased :{product.GetType().Name}");
        }
    }
}
