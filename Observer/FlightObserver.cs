using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class FlightObserver : IObserver
    {
        private readonly ISubject _airlineSubject;
        public FlightObserver(ISubject subject)
        {
            _airlineSubject = subject;
            subject.Register(this);
        }

        public void OnUpdate()
        {
            Console.WriteLine($"Flight observer gets update from {_airlineSubject.GetType()}");
        }
    }
}
