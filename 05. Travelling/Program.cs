using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
           string destination=Console.ReadLine();
            double savings = 0;
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                
                while (savings < minBudget)
                {
                    savings += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }

        }
    }
}
