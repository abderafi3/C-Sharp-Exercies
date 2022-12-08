using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                    Console.Write($"{i + 500} ");
                else
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
