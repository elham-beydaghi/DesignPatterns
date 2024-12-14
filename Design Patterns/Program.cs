using Design_Patterns.BuilderPattern;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var handleOne = new HandleOne();
            //var y = handleOne.Handle("person one");
            //Console.WriteLine(y);
            var builder = new CarBuilder();
            var x = ConstructorClass.Constructor(builder);
            Console.WriteLine(x.ToString());

        }
    }
}
