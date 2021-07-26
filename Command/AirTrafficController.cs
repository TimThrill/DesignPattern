using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AirTrafficController
    {
        public void ExecuteCommand(Command command)
        {
            command.Execute();
        }
    }
}
