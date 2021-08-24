using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAndFacade.Adapter
{
    public class ApplePowerBankAdapter : IPowerBank
    {
        private readonly IApplePowerBank _applePowerBank;

        public ApplePowerBankAdapter(IApplePowerBank applePowerBank)
        {
            _applePowerBank = applePowerBank;
        }

        public string GetInterfaceType(int position)
        {
            switch (position)
            {

                case 0:
                    return _applePowerBank.GetInterfaceType();
                default:
                    return "Unsupported charging interface";
            }
        }
    }
}
