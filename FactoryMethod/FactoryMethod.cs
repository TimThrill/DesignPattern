using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public enum PcType
    {
        GamingPc,
        OfficePc
    }

    public abstract class Pc
    {
        protected Cpu _cpu;
        protected Psu _psu;
        protected GraphicCard _grahpicCard;

        /// <summary>
        /// This is a factory method
        /// </summary>
        /// <returns></returns>
        public abstract Pc Diy();

        public string GetPcSummary()
        {
            return $"Cpu: {_cpu.GetType()}, Graphic Card: {_grahpicCard.GetType()}, PSU: {_psu.GetType()}";
        }
    }

    public class GamingPc : Pc
    {
        private DiyPcAbstractFactory _diyPcAbstractFactory;

        public GamingPc(DiyPcAbstractFactory diyPcAbstractFactory)
        {
            _diyPcAbstractFactory = diyPcAbstractFactory;
        }

        public override Pc Diy()
        {
            _cpu = _diyPcAbstractFactory.assembleCpu();
            _psu = _diyPcAbstractFactory.assemblePsu();
            _grahpicCard = _diyPcAbstractFactory.assembleGraphicCard();

            return this;
        }
    }

    public class OfficePc : Pc
    {
        private DiyPcAbstractFactory _diyPcAbstractFactory;

        public OfficePc(DiyPcAbstractFactory diyPcAbstractFactory)
        {
            _diyPcAbstractFactory = diyPcAbstractFactory;
        }

        public override Pc Diy()
        {
            _cpu = _diyPcAbstractFactory.assembleCpu();
            _psu = _diyPcAbstractFactory.assemblePsu();

            return this;
        }
    }

    public abstract class PcDiyStoreFactory
    {
        protected Pc _pc;

        public Pc Order(PcType pcType)
        {
            Console.WriteLine($"Received an order of {pcType}");
            _pc = DiyPc(pcType);
            _pc.Diy();

            return _pc;
        }

        /// <summary>
        /// This is the factory method.
        /// </summary>
        /// <returns>Return an abstract object of the product</returns>
        public abstract Pc DiyPc(PcType productType);
    }

    /// <summary>
    /// This is the concrete implementation
    /// </summary>
    public class ChinaPcDiyStoreFactory : PcDiyStoreFactory
    {
        private DiyPcAbstractFactory _diyPcAbstractFactory;

        public override Pc DiyPc(PcType productType)
        {
            switch (productType)
            {
                case PcType.GamingPc:
                    _diyPcAbstractFactory = new ChinaDiyGamingPcAbstractFactory();
                    _pc = new GamingPc(_diyPcAbstractFactory);
                    break;
                case PcType.OfficePc:
                    _diyPcAbstractFactory = new ChinaDiyOfficePcAbstractFactory();
                    _pc = new OfficePc(_diyPcAbstractFactory);
                    break;
                default:
                    Console.WriteLine("Unknown product");
                    break;
            }

            return _pc;
        }
    }

    /// <summary>
    /// This is the concrete implementation
    /// </summary>
    public class UsPcDiyStoreFactory : PcDiyStoreFactory
    {
        private DiyPcAbstractFactory _diyPcAbstractFactory;

        public override Pc DiyPc(PcType productType)
        {
            switch (productType)
            {
                case PcType.GamingPc:
                    _diyPcAbstractFactory = new UsDiyGamingPcAbstractFactory();
                    _pc = new GamingPc(_diyPcAbstractFactory);
                    break;
                case PcType.OfficePc:
                    _diyPcAbstractFactory = new UsDiyOfficePcAbstractFactory();
                    _pc = new OfficePc(_diyPcAbstractFactory);
                    break;
                default:
                    Console.WriteLine("Unknown product");
                    break;
            }

            return _pc;
        }
    }

    public abstract class Psu { }
    public class Psu220v : Psu { }
    public class Psu110v : Psu { }
    public abstract class Cpu { }
    public class CpuWithoutIntegratedGraphicCard : Cpu { }
    public class CpuWithIntegratedGraphicCard : Cpu { }
    public abstract class GraphicCard { }
    public class AmdGraphicCard : GraphicCard { }
    public class NvidiaGraphicCard : GraphicCard { }

}
