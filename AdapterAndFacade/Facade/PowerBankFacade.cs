using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAndFacade.Facade
{
    public interface IPowerBankFacade
    {
        string GetInterfaceTypeDetails(int position);
    }

    public class PowerBankFacade : IPowerBankFacade
    {
        private readonly IPowerBank _powerBank;

        public PowerBankFacade(IPowerBank powerBank)
        {
            _powerBank = powerBank;
        }

        public string GetInterfaceTypeDetails(int position)
        {
            return string.Concat(_powerBank.GetInterfaceType(position), " Voltage: 5V");
        }
    }
}
