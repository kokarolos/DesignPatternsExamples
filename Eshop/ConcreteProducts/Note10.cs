using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.ConcreteProducts
{
    public class Note10 : IProduct
    {
        public string GetBrand() => Enumerations.Brands.Samsung.ToString();
        public string GetModel() => Enumerations.Models.Note10.ToString();
        public string GetProcessor() => Enumerations.Processors.SnapDragon865.ToString();
        public string GetRam() => Enumerations.Rams.High.ToString();

    }
}
