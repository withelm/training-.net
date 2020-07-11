using System;
using System.Collections.Generic;

namespace arrays_collections
{
    internal class Program
    {
        private static List<string> ContentList = new List<string>();

        private static void Main(string[] args)
        {
            while (true)
            {
                ShowInstruction();
                string line = Console.ReadLine();

                if (line[0] == '+')
                {
                    ContentList.Add(line.Substring(2, line.Length - 2));
                    continue;
                }
                if (line[0] == '-' && line[1] == ' ')
                {
                    line = line.Substring(2, line.Length - 2);
                    ContentList.Remove(line);
                    continue;
                }
                if (line[0] == '-' && line[1] == '-')
                {
                    ContentList.Clear();
                    continue;
                }
            }
        }

        private static void ShowInstruction()
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            if (ContentList.Count > 0)
            {
                Console.WriteLine("Current list:");
                ContentList.ForEach(x => Console.WriteLine($"> {x}"));
            }
        }
    }
}