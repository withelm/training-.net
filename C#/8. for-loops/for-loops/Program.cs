﻿using System;
using System.Text.Json;

namespace for_loops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 24; j += i)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}