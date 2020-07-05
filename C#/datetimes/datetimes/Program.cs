using System;

namespace datetimes
{
    class Program
    {
        static int Anniversay1e5 = 10_000;

        static void Main(string[] args)
        {
            DateTime myBirthDate = new DateTime(1990, 1, 1);
            Console.WriteLine($"I born on {myBirthDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"I live {(DateTime.Now - myBirthDate).Days} days!");


            int nextAnniversary = (Anniversay1e5 - (DateTime.Now - myBirthDate).Days % Anniversay1e5);

            Console.WriteLine($"Next {Anniversay1e5} day anniversay will be {nextAnniversary} days!");

        }
    }
}
