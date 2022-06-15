using System;

namespace _06__Easter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int kozunakCount = int.Parse(Console.ReadLine());
            int mostPoints = 0;
            string bestBaker = "";

            for (int i = 1; i <= kozunakCount; i++)
            {
                int totalMarksForBaker = 0;
                string bakerName = Console.ReadLine();
                string command = Console.ReadLine();

                while (command != "Stop")
                {
                    int mark = int.Parse(command);
                    totalMarksForBaker += mark;
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {totalMarksForBaker} points.");  
                if (totalMarksForBaker>mostPoints)
                    
                {
                    mostPoints = totalMarksForBaker;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                    bestBaker = bakerName;
                }

                       

            }
            Console.WriteLine($"{bestBaker} won competition with {mostPoints} points!");

           




        }
    }
}
