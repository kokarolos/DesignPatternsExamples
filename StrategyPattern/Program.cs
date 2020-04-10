using StrategyPattern.TravellingStrategies;

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
