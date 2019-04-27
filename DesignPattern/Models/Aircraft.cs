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

    public class B738 : CommercialJet, IManeuver
    {
        private float? Course;

        public B738()
        {
            Course = 90.0f;
        }

        public void TurnLeft()
        {
            if (Course != null)
            {
                Course -= 90;
            }
        }
    }


}
