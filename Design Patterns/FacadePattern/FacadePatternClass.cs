namespace Design_Patterns.FacadePattern
{
    public interface IFacade
    {
        void DoOperation();
    }
    public class FacadePatternClass : IFacade
    {

        private readonly SubSystemOne _subsystemOne;
        private readonly SubSystemTwo _subsystemTwo;

        public FacadePatternClass(SubSystemOne subSystemOne, SubSystemTwo subSystemTwo)
        {
            _subsystemOne = subSystemOne;
            _subsystemTwo = subSystemTwo;   
        }
        public void DoOperation()
        {
            var x = _subsystemOne.CalculateProfit(10, 50);
            var p = _subsystemTwo.CalculateDiscount(10 , 50);
            Console.WriteLine(x - p);
        }
    }

    public class SubSystemOne
    {
        public int CalculateProfit(int a, int b)
        {
            return a * b * 100;
        }
    }

    public class SubSystemTwo
    {
        public int CalculateDiscount(int a, int b)
        {
            return (a + b) / 100;
        }
    }

}
