using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public interface IFactoryCreator
    {
        Product CreateProduct();
    }

    public abstract class Product
    {
        public string Name { get; set; }
        private string Description { get; set; }

        public abstract int CalculateProfit();

        public virtual string GetProductDiscription()
        {

            return Description;
        }
    }

    public class ConcreteProduct : Product
    {
        public override int CalculateProfit()
        {
            return 2;
        }
    }

    public class ConcreteFactory : IFactoryCreator
    {
        public Product CreateProduct()
        {
            return new ConcreteProduct();
        }
    }
}
