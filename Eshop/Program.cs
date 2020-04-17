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
            var customer = new Customer() { Email = "kokarolos@gmail.com", FirstName = "Karolos", Founds = 2000, LastName = "Koniewicz" };
            var customer2 = new Customer() { Email = "sof@gmail.com", FirstName = "Sofia", Founds = 6500, LastName = "Koniewicz" };
            eshop.PreviewAllProducts();
  

            eshop.RegisterCustomer(customer);
            eshop.RegisterCustomer(customer2);

            eshop.SetPaymentMethod(customer, 2);
            eshop.SetPaymentMethod(customer2,3);

            customer.GetCustomerInfo();

            customer.AddToBasket(eshop, eshop.Products[2]);
            customer.AddToBasket(eshop, eshop.Products[3]);
            customer.AddToBasket(eshop, eshop.Products[1]);

            customer2.AddToBasket(eshop, eshop.Products[1]);
            customer2.AddToBasket(eshop, eshop.Products[0]);

            eshop.Checkout(customer2,(x)=> customer2._basket.TotalCost <= customer2.Founds );
            eshop.Checkout(customer,(x)=> customer._basket.TotalCost <= customer.Founds);
        }
    }
}
