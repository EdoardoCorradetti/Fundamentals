using System;

namespace Average3Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Type the first number: ");
            a = int.Parse(Console.ReadLine()); //fast way to parse a string input to an integer
            Console.WriteLine("Type the second number: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the third number: ");
            c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            double avg = (double)sum / 3; //fast casting, you need to cast sum to double to get avg as double

            Console.WriteLine($"Average: {avg}");
            Console.ReadKey();
        }
    }
}
