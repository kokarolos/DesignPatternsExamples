using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    public class Eshop
    {
        private PaymentMethod _paymentMethod;
        private IEnumerable<Variation> _variations;

        //Set because All 3 variations must be included to get the total Tshirt Cost
        public void SetVariationStrategy(List<Variation> variations)
        {
            _variations = variations;
        }

        //Select between 3 Payment Methods and assing it to _paymentMethod field
        public void SelectPaymentMethod(int paymentInput)
        {
            switch (paymentInput)
            {
                case 1:
                    _paymentMethod = new CreditCard();
                    break;
                case 2:
                    _paymentMethod = new BankTransfer();
                    break;
                default:
                    _paymentMethod = new Cash();
                    break;
            }
        }
        public void PayTShirt(TShirt tshirt)
        {
            foreach (var variation in _variations)
            {
                Console.WriteLine($"Applying {variation.GetType().Name}");
                variation.Cost(tshirt);
                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}");
            }
            _paymentMethod.Pay(tshirt.Price);
        }
    }
}
