using System;

namespace making_decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = new Random().Next(3) + 1;
            int guachedNumber = int.Parse(Console.ReadLine()); ;

            switch(guachedNumber)
            {
                case 1:
                case 2:
                case 3:
                    Check(currentNumber, guachedNumber);
                    break;
                default:
                    Console.WriteLine("Wron number :'(");
                    break;
            }
            void Check(int currentNumber, int guachedNumber)
            {
                if (currentNumber > guachedNumber)
                {
                    Console.WriteLine("Too small :'(");
                    return;
                }
                if (currentNumber < guachedNumber)
                {
                    Console.WriteLine("Too big :'(");
                    return;
                }
                Console.WriteLine("You guessed!");
            }
        }
    }
}
