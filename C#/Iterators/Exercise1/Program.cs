using System;

namespace Print100EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine($"{i * 2}");
            }
            while (i != 100); //exit the iteration only when i == 100

            Console.ReadKey();
        }
    }
}
