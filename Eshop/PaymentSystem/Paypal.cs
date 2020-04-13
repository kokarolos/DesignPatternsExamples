using System;

namespace Eshop
{
    public class Paypal:PaymentMethod
    {
        public override void Pay(IProduct product)
        {
            Console.WriteLine($"Succcessfuly purchased :{product.Model} with id {product.Id}");
        }
    }
}
