using System;
using System.Collections.Generic;

namespace Eshop
{
    public sealed class Eshop
    {
        public List<IProduct> Products { get;}
        private List<Customer> _customers;

        public Eshop()
        {
            //Loading my Products through Factories (Can create easily new Products,provides flexibility)
            
            Products = new List<IProduct>()
            {
               new AppleFactory().CreateSmartPhone("IphoneX"),
               new AppleFactory().CreateSmartPhone("IPhone10"),
               new SamsungFactory().CreateSmartPhone("Note8"),
               new SamsungFactory().CreateSmartPhone("Note10"),
            };
            _customers = new List<Customer>();
        }

        //Every user must be Registered firstly otherwise he cannot checkout or select payment method
        public void RegisterCustomer(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine($"{customer.FirstName} {customer.LastName} Successfully Registered");
        }

        public void PreviewAllCustomers()=> _customers.ForEach(customer => customer.GetCustomerInfo());
        public void PreviewAllProducts()=> Products.ForEach(product => Console.WriteLine(product.GetType().Name));

        //Customer selects a method to pay
        public void SetPaymentMethod(Customer customer, int paymentType)
        {
            if(!(_customers.Contains(customer)))
            {
                Console.WriteLine("Customer isn't Registered");
            }
            else
            {
                switch (paymentType)
                {
                    case 1:
                        customer._paymentMethod = new CreditCard();
                        break;
                    case 2:
                        customer._paymentMethod = new Paypal();
                        break;
                    default:
                        customer._paymentMethod = new Paysafe();
                        break;
                }
            }
        }

        //Checking if customer's basket Total Cost is less than his actual Founds if true he can Pay the products and successfully end the checkout proccess
        public void Checkout(Customer customer,Func<Basket,bool> isAffordable)
        {
            if (!(_customers.Contains(customer)))
            {
                Console.WriteLine("Customer isn't Registered");
            }
            else
            {
                if (isAffordable(customer._basket))
                {
                    Console.WriteLine($"Customer {customer.FirstName} ready to checkout {customer._basket.TotalCost}");
                    foreach (var product in customer._basket.CustomerProducts)
                    {
                        customer._paymentMethod.Pay(product);
                    }
                }
                else
                {
                    Console.WriteLine("You cant afford this");
                }
            }
        }

    }
}
