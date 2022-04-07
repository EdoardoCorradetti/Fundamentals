using System;

namespace MaxMinXNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to calculate the max and min? ");
            int x = int.Parse(Console.ReadLine());

            int max = int.MinValue; //min value for integer variable
            int min = int.MaxValue; // max value for integer variable

            for (int i = 0; i < x; i++)
            {
                Console.Write($"Type {i + 1} number: ");
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            Console.WriteLine($"The max number is: {max}");
            Console.WriteLine($"The min number is: {min}");
            Console.ReadKey();
        }
    }
}
