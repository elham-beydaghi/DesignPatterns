using Design_Patterns.BuilderPattern;
using Design_Patterns.ObserverPattern;
using Design_Patterns.StrategyPattern;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chain of responsibility

            //var handleOne = new HandleOne();
            //var y = handleOne.Handle("person one");
            //Console.WriteLine(y);

            //builder

            //var builder = new CarBuilder();
            //var x = ConstructorClass.Constructor(builder);
            //Console.WriteLine(x.ToString());

            //StrategyPattern

            //var s = new MyStartegyPattern();
            //s.SetStrategy(new ConcreteStrategyOne());
            //var x = s.DoAlgorithm(1, 2);
            //Console.WriteLine(x.ToString());

            //observer

            //var obs = new ConcereteObservable();
            //obs.Add(new ConcreteObserver(obs));
            //obs.Add(new ConcreteObserver(obs));
            //obs.Setcount(1);
            //obs.Notify();

            
        }
    }
}
