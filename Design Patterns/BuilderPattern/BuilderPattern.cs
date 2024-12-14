namespace Design_Patterns.BuilderPattern
{
    public interface ICarBuilder
    {
        ICarBuilder SetColor(string color);
        ICarBuilder SetName(string name);
        ICarBuilder SetDate(DateTime date);

    }

    public class ConstructorClass
    {
        public static ICarBuilder Constructor(ICarBuilder carBuilder)
        {
            var x = carBuilder.SetColor("green").SetName("Benz").SetDate(DateTime.Now);
            return x;
        }
    }
    public class Car
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime RealeseDate { get; set; }

    }



    public class CarBuilder : ICarBuilder
    {
        private readonly Car carInstatnce;
        public CarBuilder()
        {
            carInstatnce = new Car();
        }
        public ICarBuilder SetColor(string color)
        {
            carInstatnce.Color = color;
            return this;
        }

        public ICarBuilder SetDate(DateTime date)
        {
            carInstatnce.RealeseDate = date;
            return this;
        }

        public ICarBuilder SetName(string name)
        {
            carInstatnce.Name = name;
            return this;
        }
    }
}
