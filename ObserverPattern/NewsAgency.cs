using System;

namespace ObserverPattern
{
    class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }
        public NewsAgency(string agencyName)
        {
            AgencyName = agencyName;
        }
        public void Update(ISubject subject)
        {
            if (subject is WeatherStation weatherStation)
            {
                Console.WriteLine($"{AgencyName} reporting temperature {weatherStation.Temperature} degree celcius");
            }
        }
    }
}
