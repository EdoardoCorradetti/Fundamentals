using System;

namespace AvgXNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers you want to calculate the average? ");
            int x = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i=0; i<x; i++) //exit when x = i
            {
                Console.Write($"Number {i + 1}: "); //i is 0 the first time so you need to add 1 to that value

                sum += int.Parse(Console.ReadLine()); //sum += is the abbreviation for sum = sum + input
            }

            Console.WriteLine($"The average is {(double)sum / x}"); //parse to get a double in output
            Console.ReadKey();
        }
    }
}
