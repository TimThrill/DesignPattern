using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class AirportObserver : IObserver
    {
        private readonly ISubject _airlineSubject;
        public AirportObserver(ISubject subject)
        {
            _airlineSubject = subject;
            subject.Register(this);
        }

        public void OnUpdate()
        {
            Console.Write($"Airport observer gets update from {_airlineSubject.GetType()}.");
        }
    }
}
