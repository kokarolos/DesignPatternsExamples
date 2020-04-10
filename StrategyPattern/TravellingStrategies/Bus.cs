
namespace StrategyPattern.TravellingStrategies
{
    class Bus : TravelStrategy
    {
        public Bus()
        {
            KilometerCost = 20;
        }

        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
