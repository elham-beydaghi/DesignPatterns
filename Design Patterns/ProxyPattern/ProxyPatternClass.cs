namespace Design_Patterns.ProxyPattern
{
    public interface IRequest
    {
        int GetThePrice(string ProductName);
    }
    public class ProxyClass : IRequest
    {
        private  HeavyInstantiationClass _heavyInstantiationClass;

        public int GetThePrice(string pname)
        {
            if (_heavyInstantiationClass == null)
                _heavyInstantiationClass = new HeavyInstantiationClass();
            return _heavyInstantiationClass.GetThePrice(pname);

        }
    }

    public class HeavyInstantiationClass : IRequest
    {
        public HeavyInstantiationClass()
        {
            //heavy operation
        }
        public int GetThePrice(string pName)
        {
            return 1000;
        }
    }

}
