using StrategyPattern.TravellingStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelerPlanner travelerPlanner = new TravelerPlanner();
            travelerPlanner.SetTravelStrategy(new Car());
            travelerPlanner.Drive(100);
        }
    }
}
