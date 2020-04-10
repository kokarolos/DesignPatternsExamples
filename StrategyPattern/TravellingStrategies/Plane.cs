
namespace StrategyPattern.TravellingStrategies
{
    public class Plane : TravelStrategy
    {
        public Plane()
        {
            KilometerCost = 50;
        }
        public override decimal Drive(int kilometers)
        {
            if(kilometers>1000)
            {
                KilometerCost = 15;
            }
            return kilometers * KilometerCost;
        }

    }
}
