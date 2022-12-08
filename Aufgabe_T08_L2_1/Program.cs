using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_T08_L2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 1;
            for (int i = 0; i < 9; i++)
            {
                zahl += i;
                Console.Write($"{zahl} ");
            }
            Console.WriteLine();


            //for (int i = 1; i < 37; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.Write($" {i += j}");
            //    }

            //}
            //Console.WriteLine();
        }
    }
}
