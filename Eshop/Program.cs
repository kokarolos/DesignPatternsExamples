using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var eshop = new Eshop();
            var basket = new Basket();
            Customer c1 = new Customer { Id = 1, Email = "karol@koniewicz.com", FirstName = "Karol", LastName = "Koniewicz", Founds = 20000 };
            Customer c2 = new Customer { Id = 2, Email = "sofia@koniewicz.com", FirstName = "Sofia", LastName = "Panta", Founds = 25000 };
            eshop.RegisterCustomer(c1);
            eshop.RegisterCustomer(c2);
            eshop.SetPaymentMethod(c1, 1);
            c1.GetCustomerInfo();
            eshop.Checkout(c1);
            eshop.PrieviewAllCustomers();

        }
    }

    public sealed class Eshop
    {
        private List<IProduct> _products;
        private List<Customer> _customers;
        private Basket _basket;

        public Eshop()
        {
            _products = new List<IProduct>()
            {

            };
            _customers = new List<Customer>();
            _basket = new Basket();
        }

        public void RegisterCustomer(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine($"{customer.FirstName} {customer.LastName} Successfully Registered");
        }
        public void PrieviewAllCustomers()=> _customers.ForEach(customer => Console.WriteLine(customer.FirstName));

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
        public void Checkout(Customer customer)
        {
            if(_basket.IsAffordable(customer))
            {
                Console.WriteLine($"Thank you for purchasing, Total Amount is {_basket.TotalCost} ");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

    }
    public sealed class Basket
    {
        //public List<IProduct> _products=new List<IProduct>();
        public decimal TotalCost { get; set; }

        public Basket()
        {

        }

        public bool IsAffordable(Customer customer) => customer.Founds >= TotalCost;
    }
}
