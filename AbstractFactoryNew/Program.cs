using AbstractFactoryNew.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryNew
{
    class Program
    {
        static void Main(string[] args)
        {
            var businessClient = new Client(new ElegantClothFactory());
            Console.WriteLine(businessClient.DescribeYourClothes());

            var studentClient = new Client(new CasualClothFactory());
            Console.WriteLine(studentClient.DescribeYourClothes());

        }
    }
}
