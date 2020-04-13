using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            NewsAgency agency1 = new NewsAgency("Alpha");
            NewsAgency agency2 = new NewsAgency("Beta");
            NewsAgency agency3 = new NewsAgency("Gamma");
            NewsAgency agency4 = new NewsAgency("Delta");

            weatherStation.Attach(agency1);
            weatherStation.Attach(agency2);
            weatherStation.Attach(agency3);
            weatherStation.Attach(agency4);
            weatherStation.Temperature = 22.1f;
            weatherStation.Temperature = 37.5f;
            weatherStation.Temperature = 49.4f;
            weatherStation.Temperature = 0.4f;
        }
    }
}
