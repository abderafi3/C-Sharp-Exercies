using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 5 - j; i++)
                {
                    Console.Write(" ");
                }
                Console.ForegroundColor= ConsoleColor.Green;
                for (int i = 0; i < 2 * j + 1; i++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}

