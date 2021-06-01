using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Product
    {
        public string Name { get; set; }

        public Product (string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Product: {Name}";
        }
    }

    public class ElectronicProduct : Product
    {
        public ElectronicProduct() : base("Electronic") { }
    }

    public class AppliancesProduct : Product
    {
        public AppliancesProduct() : base("Appliances") { }
    }

    public abstract class Creator
    {
        private Product _product;

        public Creator()
        {
            _product = CreateMethod();
        }

        /// <summary>
        /// This is factory method
        /// </summary>
        /// <returns>Return an abstract object of the product</returns>
        public abstract Product CreateMethod();

        public string GetName()
        {
            return _product.ToString();
        }
    }

    public class ElectronicProductCreator : Creator
    {
        public override Product CreateMethod()
        {
            return new ElectronicProduct();
        }
    }

    public class AppliancesProductCreator : Creator
    {
        public override Product CreateMethod()
        {
            return new AppliancesProduct();
        }
    }
}
