using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// This interface contains a series of abstract creation methods for the product
    /// </summary>
    public interface DiyPcAbstractFactory
    {
        Psu assemblePsu();
        Cpu assembleCpu();
        GraphicCard assembleGraphicCard();
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class ChinaDiyGamingPcAbstractFactory : DiyPcAbstractFactory
    {
        public Cpu assembleCpu()
        {
            return new CpuWithoutIntegratedGraphicCard();
        }

        public GraphicCard assembleGraphicCard()
        {
            return new AmdGraphicCard();
        }

        public Psu assemblePsu()
        {
            return new Psu220v();
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class UsDiyGamingPcAbstractFactory : DiyPcAbstractFactory
    {
        public Cpu assembleCpu()
        {
            return new CpuWithoutIntegratedGraphicCard();
        }

        public GraphicCard assembleGraphicCard()
        {
            return new NvidiaGraphicCard();
        }

        public Psu assemblePsu()
        {
            return new Psu110v();
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class ChinaDiyOfficePcAbstractFactory : DiyPcAbstractFactory
    {
        public Cpu assembleCpu()
        {
            return new CpuWithIntegratedGraphicCard();
        }

        public GraphicCard assembleGraphicCard()
        {
            return null;
        }

        public Psu assemblePsu()
        {
            return new Psu220v();
        }
    }

    /// <summary>
    /// Concrete implementation
    /// </summary>
    public class UsDiyOfficePcAbstractFactory : DiyPcAbstractFactory
    {
        public Cpu assembleCpu()
        {
            return new CpuWithIntegratedGraphicCard();
        }

        public GraphicCard assembleGraphicCard()
        {
            return null;
        }

        public Psu assemblePsu()
        {
            return new Psu220v();
        }
    }
}
