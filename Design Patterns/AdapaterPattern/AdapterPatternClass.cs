using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.AdapaterPattern
{
    public interface IAdapater
    {
        void RequestedMethod();
    }
    public class ConcreteAdapter : IAdapater
    {
        private readonly Adaptee _adaptee;
        public ConcreteAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void RequestedMethod()
        {
            _adaptee.RequestedMethod();
        }
    }


    public class Adaptee
    {
        public void RequestedMethod()
        {
            Console.WriteLine("Im Adaptee !!!!");
        }
    }
}
