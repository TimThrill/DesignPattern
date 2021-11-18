using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class TemplateMethod
    {
        public void TemplateMethodCall()
        {
            Console.WriteLine("Start sequence of methods in the template");
            PrimitiveMethodA();
            ConcreteMethod();
            Hook();
            Console.WriteLine("End of template method");
        }

        /// <summary>
        /// This is the primitive method. It should not be overridden by concrete classes
        /// </summary>
        private void PrimitiveMethodA()
        {
            Console.WriteLine("This is PrimitiveMethodA.");
        }

        /// <summary>
        /// Concrete classes must override this abstract method
        /// </summary>
        protected abstract void ConcreteMethod();

        /// <summary>
        /// The hook method is doing nothing by default, although concrete classes can enrich/override it if necessary
        /// </summary>
        protected void Hook()
        {
        }
    }

    public class ConcreteTemplateMethod : TemplateMethod
    {
        protected sealed override void ConcreteMethod()
        {
            Console.WriteLine($"This is ConcreteMethod in {nameof(ConcreteTemplateMethod)} class");
        }
    }
}
