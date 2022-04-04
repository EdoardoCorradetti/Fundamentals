using System;

namespace Sum2Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string tmp;
            Console.Write("Type the fist number: ");
            tmp = Console.ReadLine();
            a = int.Parse(tmp); //parse is a method to convert sting (tmp) into integer (a or b)

            Console.Write("Type the second number: ");
            tmp = Console.ReadLine();
            b = int.Parse(tmp);

            int s = a + b;

            Console.WriteLine("Sum (via Concatenation): " + s);
            Console.WriteLine("Sum: {0} (via Composite Format)", s);
            Console.WriteLine("Sum detailed (via Interpolation1): {0}+{1}={2}", a, b, s);
            Console.WriteLine($"Sum detailed (via Interpolation2): {a}+{b}={s}");
            Console.ReadKey();
        }
    }
}