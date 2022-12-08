using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 51; i < 70; i++)
            {
                if (i % 3 == 1) 
                    Console.Write($"{i + 100} ");
                else
                    Console.Write($"{i} ");
            }
            Console.WriteLine();

            //for (int i = 51, j = 152; i < 70 || j < 168; i++, j++)
            //{
            //    if (j % 3 == 0)
            //    {
            //        Console.Write($"{j-1} ");

            //    }
            //    else
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
        }
    }
}
