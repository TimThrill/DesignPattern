using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new AirlineSubject();
            var flightObserver = new FlightObserver(subject);
            var airportObserver = new AirportObserver(subject);

            subject.Update();
        }
    }
}
