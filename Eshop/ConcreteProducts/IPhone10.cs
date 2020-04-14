using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.ConcreteProducts
{
    public class IPhone10 : IProduct
    {
        public string GetBrand() => Enumerations.Brands.Apple.ToString();
        public string GetProcessor() => Enumerations.Processors.A12.ToString();
        public string GetRam() => Enumerations.Rams.Medium.ToString();
        public string GetModel() => Enumerations.Models.IPhone10.ToString();
    }
}
