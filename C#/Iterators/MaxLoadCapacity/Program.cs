using System;

namespace MaxLoadCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double tare = 22;
            double maxload = 1500;

            int packagecount = 0;
            bool end = false;
            int choice = 1;

            while (!end) //if end = true exit the loop
            {
                Console.WriteLine($"Loaded weight: {sum}");
                Console.WriteLine($"Remaining weight: {maxload-sum}");
                Console.Write("Package weight: ");
                double weight = double.Parse(Console.ReadLine());

                if (weight + sum > maxload)
                    Console.WriteLine("\nWARNING: Maximum load capacity exceeded, try again.\n");
                else
                {
                    sum += weight;
                    packagecount++;
                }

                if (sum == maxload)
                {
                    Console.WriteLine($"\nMaximum load capacity reached\n");
                    break;  //exit the loop
                }

                Console.Write("Do you need to add another package? (0 = NO    1 = YES) ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    end = true;
            }

            Console.WriteLine($"Total weight: {sum + tare}");
            Console.WriteLine($"Total package: {packagecount}");

            Console.ReadKey();
        }
    }
}
