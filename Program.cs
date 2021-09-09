﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            demonstrateIfElse();
            printPattern(20);
            Console.ReadKey();
        }

        private static void demonstrateIfElse()
        {
            int i = 20, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }
        }

        private static void printPattern(int v)
        {
            for (int i = v; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
