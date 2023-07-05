namespace CarTask;
class Progam
{
    static void Main(string[] args)
    {
        var car1 = new Car();
        var car2 = new Car();
        var car3 = new Car();

        Console.WriteLine("Enter data for car 1:");
        car1.Input();
        Console.WriteLine();

        Console.WriteLine("Enter data for car 2:");
        car2.Input();
        Console.WriteLine();

        Console.WriteLine("Enter data for car 3:");
        car3.Input();
        Console.WriteLine();

        car1.ChangePrice(0.9);
        Console.WriteLine("Price change for car 1:");
        car1.Print();

        car2.ChangePrice(0.9);
        Console.WriteLine("Price change for car 2:");
        car2.Print();

        car3.ChangePrice(0.9);
        Console.WriteLine("Price change for car 3:");
        car3.Print();

        car1.Color = "Blue";
        Console.WriteLine("Color change for car 1:");
        car1.Print();

        car2.Color = "Red";
        Console.WriteLine("Color change for car 2:");
        car2.Print();

        car3.Color = "Green";
        Console.WriteLine("Color change for car 3:");
        car3.Print();
    }
}