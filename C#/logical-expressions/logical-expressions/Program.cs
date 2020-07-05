using System;

namespace logical_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var welcom = DateTime.Now.Hour switch
            {
                var x when 6 <= x  && x < 12 => "Good Morning",
                var x when 12 <= x && x < 18 => "Good Afternoon",
                var x when 18 <= x && x < 22 => "Good Evening",
                _ => "Good night"
            };
            Console.WriteLine(welcom);
        }
    }
}
