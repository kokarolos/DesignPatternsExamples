using AbstractFactoryNew.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryNew
{
    public class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;
        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
        }

        public string DescribeYourClothes()
        {
            return $"Today I'm dressed in: {_shirt.GetType().Name} anmd {_trousers.GetType().Name}";
        }

    }
}
