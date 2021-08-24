using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAndFacade
{
    public interface IPowerBank
    {
        string GetInterfaceType(int position);
    }

    public class PowerBank : IPowerBank
    {
        private static readonly Dictionary<int, string> _interfaces = new Dictionary<int, string>
        {
            { 0, $"{nameof(PowerBank)} USB-A" },
            { 1, $"{nameof(PowerBank)} USB-C" }
        };

        public string GetInterfaceType(int position)
        {
            return _interfaces[position];
        }
    }

    public interface IApplePowerBank
    {
        string GetInterfaceType();
    }

    public class ApplePowerBank : IApplePowerBank
    {
        public string GetInterfaceType()
        {
            return $"{nameof(ApplePowerBank)} Lightening";
        }
    }
}
