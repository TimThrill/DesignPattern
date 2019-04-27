using DesignPattern.Interfaces;
using DesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    public class ProxyAircraft : IManeuver
    {
        private readonly B738 _aircraft;

        public ProxyAircraft()
        {
            _aircraft = new B738();
        }

        public void TurnLeft()
        {
            if (true)
            {
                _aircraft.TurnLeft();
            }
        }
    }
}
