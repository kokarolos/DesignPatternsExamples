using System;

namespace StrategyPattern
{
    public class TravelerPlanner
    {
        private TravelStrategy _travelStrategy;
        public void SetTravelStrategy(TravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }
        public void Drive(int kilometers)
        {
            var cost = _travelStrategy.Drive(kilometers);
            Console.WriteLine("Cost of the drive: "+cost);
        }
    }
}
