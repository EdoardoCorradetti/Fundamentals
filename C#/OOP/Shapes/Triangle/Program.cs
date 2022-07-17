using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the first side: ");
            double s1 = double.Parse(Console.ReadLine());
            Console.Write("Type the second side: ");
            double s2 = double.Parse(Console.ReadLine());
            Console.Write("Type the third side: ");
            double s3 = double.Parse(Console.ReadLine());
            Triangle t = new Triangle(s1, s2, s3);
            if (t.IsBuildable())
                Console.WriteLine(t.PrintTriangleData());
            else
                Console.WriteLine($"With the sides: {s1}, {s2}, {s3} - you cannot build a triangle.");
            Console.ReadKey();
        }
    }
}
