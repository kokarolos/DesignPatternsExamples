using System;

namespace Eshop
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Founds { get; set; }
        public PaymentMethod _paymentMethod { get; set; }
        private Basket _basket;
        public Customer()
        {
            _basket = new Basket();
        }

        public void GetCustomerInfo()
        {
            Console.WriteLine($"Customer {FirstName} {LastName} has {Founds} available and setted Payment Method to {_paymentMethod.GetType().Name}");
        }
        public void AddToBasket(IProduct product)
        {
        //    _basket._products.Add(product);
        //    _basket.TotalCost += product.GetPrice();
        }

    }
}
