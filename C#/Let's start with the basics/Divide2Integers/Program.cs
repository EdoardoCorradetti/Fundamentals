using System;

namespace Divide2Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; //inline variable declaration
            string tmp;
            Console.Write("Write the dividend: ");
            tmp = Console.ReadLine();
            a = int.Parse(tmp);

            Console.Write("Write the divisor: ");
            tmp = Console.ReadLine();
            b = int.Parse(tmp);

            int qi = a / b;
            int r = a % b;
            double qr = (double)a / b; // fast casting, you need to transform a in double to get qr double

            Console.WriteLine($"{a}/{b}");
            Console.WriteLine($"The integer quotient is: {qi}");
            Console.WriteLine($"The remainder is: {r}");
            Console.WriteLine($"The real quotient is: {qr}");
            Console.ReadKey();
        }
    }
}
