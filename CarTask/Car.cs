namespace CarTask
{
    public class Car
    {
        public const string CompanyName = "General Motors";

        private string _color;

        public string Name;
        public double Price;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Car() //: this("Unknown", "transparent", -1.0)
        {

        }

        public Car(string name, string color, double price)
        {
            Name = name;
            Color = color;
            Price = price;
        }

        public void Input()
        {
            Console.Write("Enter car name: ");
            Name = Console.ReadLine();
            Console.Write("Enter car color: ");
            Color = Console.ReadLine();
            bool parsed;
            do
            {
                Console.Write("Enter car price: ");

                var input = Console.ReadLine();

                parsed = double.TryParse(input, out Price);
                if (!parsed)
                {
                    Console.WriteLine("Can't parse entered price");
                }
            } while (!parsed);
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void ChangePrice(double percent)
        {
            Price *= percent;
        }

        public static bool operator ==(Car a, Car b)
        {
            return a.Name == b.Name && a.Price == b.Price;
        }

        public static bool operator !=(Car a, Car b)
        {
            return a.Name != b.Name || a.Price != b.Price;
        }

        public override string ToString()
        {
            return $"Name: {Name}; Color: {Color}; Price: ${Price}";
        }
    }
}
