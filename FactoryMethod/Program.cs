using System;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pcFactory = new ChinaPcDiyStoreFactory();
            var pc = pcFactory.Order(PcType.GamingPc);
            Console.WriteLine(pc.GetPcSummary());
        }
    }
}
