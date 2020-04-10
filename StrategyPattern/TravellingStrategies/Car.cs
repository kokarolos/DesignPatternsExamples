
namespace StrategyPattern.TravellingStrategies
{
    public class Car : TravelStrategy
    {
        public Car()
        {
            KilometerCost = 25;
        }
        public override decimal Drive(int kilometers)
        {
            return kilometers * KilometerCost;
        }
    }
}
