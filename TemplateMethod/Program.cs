using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var templateMethod = new ConcreteTemplateMethod();
            templateMethod.TemplateMethodCall();
        }
    }
}
