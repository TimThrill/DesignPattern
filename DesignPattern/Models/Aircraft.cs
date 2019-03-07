using DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Models
{
    public enum AircraftType
    {
        Commericial,
        Private
    }

    public class CommercialJet : IAircraft
    {
        public int GetType()
        {
            return (int)AircraftType.Commericial;
        }
    }

    public class PrivateJet : IAircraft
    {
        public int GetType()
        {
            return (int)AircraftType.Private;
        }
    }
}
