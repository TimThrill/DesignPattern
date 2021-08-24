using AdapterAndFacade.Adapter;
using AdapterAndFacade.Facade;
using System;

namespace AdapterAndFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter pattern:");
            IApplePowerBank applePowerBank = new ApplePowerBank();
            IPowerBank applePowerBankAdapter = new ApplePowerBankAdapter(applePowerBank);

            Console.WriteLine(applePowerBankAdapter.GetInterfaceType(0));


            Console.WriteLine("Facade pattern:");
            IPowerBank powerBank = new PowerBank();
            IPowerBankFacade powerBankFacade = new PowerBankFacade(powerBank);
            Console.WriteLine(powerBankFacade.GetInterfaceTypeDetails(0));
        }
    }
}
