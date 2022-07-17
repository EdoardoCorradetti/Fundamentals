using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.Write("Type the rectangle's base: ");
            r.Base = double.Parse(Console.ReadLine());
            Console.Write("Type the rectangle's height: ");
            r.Height = double.Parse(Console.ReadLine());
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
