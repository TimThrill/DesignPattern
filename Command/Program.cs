using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var airTrafficController = new AirTrafficController();
            var flight = new AirCraft("QF101");
            var takeOffCommand = new AircraftTakeOffCommand(flight);
            var landingCommand = new AircraftLandingCommand(flight);
            airTrafficController.ExecuteCommand(takeOffCommand);
            airTrafficController.ExecuteCommand(landingCommand);
        }
    }
}
