using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(); //instance constructor
            Console.Write("Type the square's side: ");
            s.side = double.Parse(Console.ReadLine());

            Console.WriteLine("The square's perimeter is: " + s.perimeter());
            Console.WriteLine("The square's area is: " + s.area());
            Console.WriteLine("The square's diagonal is: " + s.diagonal());
            Console.ReadKey();
        }
    }
}
