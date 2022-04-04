using System;

namespace MaxMinOrEquals
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Type the first number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Type the second number: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.Write($"Max = {a}\nMin = {b}");
            }

            else
            {
                if (a == b)
                {
                    Console.Write("The numbers are the same");
                }
                else
                {
                    Console.Write($"Max = {b}\nMin = {a}");
                }
            }
            Console.ReadKey();
        }
    }
}
