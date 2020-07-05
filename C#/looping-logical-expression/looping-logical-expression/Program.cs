using System;

namespace looping_logical_expression
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            if (number > 1) // convert this to while
            {
                for (int candidateFactor = 2; candidateFactor * candidateFactor < number; candidateFactor++)
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write($"{candidateFactor} ");
                        Console.Write($"{number / candidateFactor} ");
                    }
                }
            }
        }
    }
}