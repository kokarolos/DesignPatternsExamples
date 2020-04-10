using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory.Enumerations;

namespace AbstractFactory.AbstractFactoryFolder
{
    class Mac:IBrand
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();
        }
    }
}
