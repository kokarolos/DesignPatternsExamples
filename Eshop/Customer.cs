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
        public Basket _basket { get; set; }

        public Customer()
        {
            _basket = new Basket();
        }

        //Customer Brief 
        public void GetCustomerInfo()
        {
            Console.WriteLine($"Customer {FirstName} {LastName} has {Founds} available and setted Payment Method to {_paymentMethod.GetType().Name}");
        }
        public void AddToBasket(Eshop eshop,IProduct product)
        {
            if(eshop.Products.Contains(product))
            {
                _basket.CustomerProducts.Add(product);
                _basket.TotalCost += product.GetPrice();
            }
        }

    }
}
