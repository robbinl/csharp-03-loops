﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_loops_do_while_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a series of integer numbers, 0 to stop
            // Display sum of all numbers entered.

            int num;
            int sum = 0;

            do {
                Console.Write("Enter an integer number (0 to exit): ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);

            Console.WriteLine($"\nSum of Numbers {sum}");
        }
    }
}
