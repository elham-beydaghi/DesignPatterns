using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StrategyPattern
{
    public interface IStrategy
    {
        int DoAlgorithm(int a , int b);
    }
    public class ConcreteStrategyOne : IStrategy
    {
        public int DoAlgorithm(int a, int b)
        {
            return a * b;
        }
    }

    public class ConcreteStrategyTwo : IStrategy
    {
        public int DoAlgorithm(int a, int b)
        {
            return a +  b;
        }
    }
    public class MyStartegyPattern
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int DoAlgorithm(int a, int b)
        {
            return strategy.DoAlgorithm(a, b);
        }

    }
}
