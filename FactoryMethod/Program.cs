using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetProductName(new AppliancesProductCreator());
            GetProductName(new ElectronicProductCreator());
        }

        public static void GetProductName (Creator creator)
        {
            Console.WriteLine($"Product name is {creator.GetName()}");
        }
    }
}
