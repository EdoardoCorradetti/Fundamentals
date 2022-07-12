using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the circle's radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle c = new Circle(radius);
            Console.WriteLine(c.PrintCircleData());
            Console.ReadKey();
        }
    }
}
