namespace Design_Patterns.FactoryPattern
{

    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    public interface IProductA
    {
        int GetProfit();
    }

    public interface IProductB { 
        void DoSomething();
    }

    public class ConcreteProductBTwo : IProductB
    {
        public void DoSomething()
        {
            Console.WriteLine("Im product B Two!");
        }
    }

    public class ConcreteProductATwo : IProductA
    {
        public int GetProfit()
        {
            return 100;
        }
    }

    public class ConcreteProductAOne : IProductA
    {
        public int GetProfit()
        {
            return 10;
        }
    }
    public class ConcreteProductBOne : IProductB
    {
        public void DoSomething()
        {
            Console.WriteLine("Im product B One!");
        }
    }

    public class ConcreteAbstractFactoryA : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductAOne();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductBOne();
        }
    }


    public class ConcreteAbstractFactoryB : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductATwo();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductBTwo();
        }
    }
}
