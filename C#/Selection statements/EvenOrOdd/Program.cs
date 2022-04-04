using System;

namespace EvenOrOdd
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Type the number: ");
            int n = int.Parse(Console.ReadLine());

            int r = n % 2;

            if (r == 0) //if the remainder of the division is 0
            {
                Console.Write($"{n} is even");
            }
            else //otherwise
            {
                Console.Write($"{n} is odd");
            }
            Console.ReadKey();
        }
    }
}
