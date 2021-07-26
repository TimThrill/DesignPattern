using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AirCraft
    {
        private string _callsign;

        public AirCraft (string callsign)
        {
            _callsign = callsign;
        }

        public void TakeOff()
        {
            Console.WriteLine($"Flight {_callsign} take off");
        }

        public void Landing()
        {
            Console.WriteLine($"Flight {_callsign} landing");
        }
    }
    public abstract class Command
    {
        public abstract void Execute();
    }

    public class AircraftTakeOffCommand : Command
    {
        private AirCraft _aircraft;

        public AircraftTakeOffCommand(AirCraft aircraft)
        {
            _aircraft = aircraft;
        }

        public override void Execute()
        {
            _aircraft.TakeOff();
        }
    }

    public class AircraftLandingCommand : Command
    {
        private AirCraft _aircraft;

        public AircraftLandingCommand(AirCraft airCraft)
        {
            _aircraft = airCraft;
        }

        public override void Execute()
        {
            _aircraft.Landing();
        }
    }
}
