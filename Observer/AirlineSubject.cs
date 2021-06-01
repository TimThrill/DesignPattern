using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class AirlineSubject : ISubject
    {
        private readonly List<IObserver> _observers;

        public AirlineSubject()
        {
            _observers = new List<IObserver>();
        }
        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            var item = _observers.SingleOrDefault(o => o.Equals(observer));
            _observers.Remove(item);
        }

        public void Update()
        {
            foreach(var observer in _observers)
            {
                observer.OnUpdate();
            }
        }
    }
}
