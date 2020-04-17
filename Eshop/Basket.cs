using System.Collections.Generic;

namespace Eshop
{
    public sealed class Basket
    {
        public List<IProduct> CustomerProducts = new List<IProduct>();
        public decimal TotalCost { get; set; }
    }
}
