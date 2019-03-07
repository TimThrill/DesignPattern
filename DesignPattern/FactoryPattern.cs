using DesignPattern.Interfaces;
using DesignPattern.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Factory_method_pattern
    /// In class-based programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created.
    /// This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.
    /// </summary>
    public class AircraftFactory
    {
        private readonly ILogger<AircraftFactory> _logger;

        public AircraftFactory() { }
        public AircraftFactory(ILogger<AircraftFactory> logger)
        {
            _logger = logger;
        }

        public IAircraft GetAircraft(AircraftType type)
        {
            IAircraft aircraft = null;
            switch(type)
            {
                case AircraftType.Commericial:
                    aircraft =  new CommercialJet();
                    break;
                case AircraftType.Private:
                    aircraft = new PrivateJet();
                    break;
                default:
                    break;
            }
            _logger.LogInformation($"Get aircraft type: {aircraft.GetType()}.");
            return aircraft;
        }
    }
}
