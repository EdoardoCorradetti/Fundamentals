using System;

namespace PositiveOrNegative
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Type the number: ");
            float n = float.Parse(Console.ReadLine());

            if(n< 0) //if the number is smaller than 0
            {
                Console.Write($"{n} is negative");
            }
            else //otherwise
            {
                Console.Write($"{n} is positive");
            }
            Console.ReadKey();
        }
    }
}
